using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using NFluidsynth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SM64Mus
{
    public partial class MainForm : Form
    {
        List<midiTrack> tracks = new List<midiTrack>();
        internal static MainForm instance;
        internal static MidiFile loadedMid = null;
        static Player player;
        static Synth syn;
        static AudioDriver drv;
        public int NLSTChoice
        {
            get
            {
                return NLSTChoices.SelectedIndex;
            }
            set
            {
                NLSTChoices.SelectedIndex = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NLSTChoices.Items.AddRange(NLSTUtils.NLISTNames);
            NLSTChoices.SelectedIndex = 0;
        }

        void loadMidi(string path)
        {
            var readings = new ReadingSettings();
            readings.InvalidChannelEventParameterValuePolicy = InvalidChannelEventParameterValuePolicy.ReadValid;
            readings.InvalidChunkSizePolicy = InvalidChunkSizePolicy.Ignore;
            loadedMid = MidiFile.Read(path, readings);
            if (player != null)
                player.Stop();
            tracks.Clear(); // reset loaded tracks

            var midTracks = loadedMid.GetTrackChunks().ToList();
            for (int i = 0; i < midTracks.Count; i++)
            {
                tracks.Add(new midiTrack(i, "Track " + i));
            }
            fixOverflowingInstruments();
            channelsGrid.SetObjects(tracks);
        }

        private void channelsGrid_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column.AspectName != "instrumentName")
                return;
            ComboBox cb = new ComboBox();
            cb.Bounds = e.CellBounds;
            cb.Font = ((BrightIdeasSoftware.ObjectListView)sender).Font;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            var channel = (e.RowObject as midiTrack).channel;
            if (channel != 10) // channel 10 is percussion!
                cb.Items.AddRange(NLSTUtils.instrumentNames[NLSTChoice]);
            else
                cb.Items.AddRange(NLSTUtils.percussionNames);
            var instrument = (e.RowObject as midiTrack).instrument;
            if (instrument == -1)
            {
                e.Cancel = true;
                return;
            }
            if (instrument > cb.Items.Count - 1)
                cb.SelectedIndex = 0;
            else
                cb.SelectedIndex = instrument;
            e.Control = cb;
        }
        private void channelsGrid_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column.AspectName == "instrumentName")
            {
                (e.RowObject as midiTrack).instrument = (e.Control as ComboBox).SelectedIndex;
                if (player != null && player.Status == FluidPlayerStatus.Playing)
                {
                    syn.ProgramChange((e.RowObject as midiTrack).channel - 1, (e.Control as ComboBox).SelectedIndex);
                }
            }
            
        }

        private void NLSTChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            channelsGrid.RefreshObjects(tracks);
            fixOverflowingInstruments();
            if (player != null && player.Status == FluidPlayerStatus.Playing)
            {
                reloadMidiSameSpot();
            }
        }

        /// <summary>
        /// Export the MIDI
        /// </summary>
        void exportMID()
        {
            loadedMid.Write("out.mid", overwriteFile: true);
        }

        /// <summary>
        /// Export the MIDI to memory
        /// </summary>
        /// <returns>A byte array representing the MIDI</returns>
        byte[] exportMIDBytes()
        {
            MemoryStream stream = new MemoryStream();
            loadedMid.Write(stream, MidiFileFormat.MultiTrack);
            return stream.ToArray();
        }

        /// <summary>
        /// Renders the currently applied settings to a MIDI file (in memory) and then sets up a player
        /// </summary>
        void setupPlayerForPlayback()
        {
            if (drv != null)
                drv.Dispose();
            if (player != null)
                player.Dispose();
            if (syn != null)
                syn.Dispose();
            var settings = new Settings();
            settings[ConfigurationKeys.SynthAudioChannels].IntValue = 2;
            syn = new Synth(settings);
            syn.Gain = 0.5f;
            syn.LoadSoundFont(@"Soundbanks\" + (NLSTChoice + 10).ToString("X2") + ".dls", true);
            for (int i = 0; i < 16; i++)
                syn.SoundFontSelect(i, 1);
            
            player = new Player(syn);
            var mid = exportMIDBytes();
            player.AddMem(mid, 0, mid.Length);
            drv = new AudioDriver(settings, syn);

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (loadedMid == null)
            {
                MessageBox.Show("Load a midi first!");
                return;
            }
            exportMID();
            setupPlayerForPlayback();
            player.Play();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        /// <summary>
        /// Re-Generates and re-loads the current MIDI file, and also returns it to the same position it was before
        /// </summary>
        public void reloadMidiSameSpot()
        {
            if (player==null || player.Status != FluidPlayerStatus.Playing)
                return;
            var tick = player.CurrentTick; // save position
            player.Stop(); // stop
            // re-export
            setupPlayerForPlayback();
            while (player.CurrentTick <= 0) { } // give it time to initialize?
            fluidSynthExtras.fluid_player_seek(player.Handle, tick); // go back to where we were
            player.Play(); // play!
            
        }

        private void loadMIDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "MIDI files|*.mid;*.midi";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                loadMidi(theDialog.FileName);
            }
        }


        private void savem64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedMid == null)
            {
                MessageBox.Show("Load a midi first!");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Super Mario 64 Sequence|*.m64";
            saveFileDialog1.Title = "Save m64";
            saveFileDialog1.OverwritePrompt = true;
            exportMID();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                midi2m64.convertMidi("out.mid", saveFileDialog1.FileName);
            }

        }

        /// <summary>
        /// Resets instruments that go over their limit for the specified soundbank
        /// </summary>
        void fixOverflowingInstruments()
        {
            foreach (midiTrack t in tracks)
            {
                //if (t.originalInstrument != -1)
                //t.instrument = t.originalInstrument; // reset to orig
                if (
                    (t.channel != 10 && t.instrument > NLSTUtils.instrumentNames[NLSTChoice].Count() - 1) ||
                    ((t.channel == 10 && t.instrument > NLSTUtils.percussionNames.Length - 1)) // avoid fixing percussion tracks!
                    )
                {
                    t.instrument = 0;
                }
            }
        }


    }

    class midiTrack
    {
        TrackChunk track;
        int trackIndex;
        public string trackName;
        int _instrument = -1;
        int _channel = -1;
        public int originalInstrument = -1;
        public int channel
        {
            get
            {
                return _channel + 1;
            }
            set
            {
                _channel = value - 1;
                foreach (var midEvent in track.Events)
                {
                    var cprop = midEvent.GetType().GetProperty("Channel");// yeah, using reflection is lazy
                    if (cprop != null)
                    {
                        cprop.SetValue(midEvent, (FourBitNumber)_channel);
                    }
                }

                
                MainForm.loadedMid.Chunks[trackIndex] = track;
                MainForm.instance.reloadMidiSameSpot();
            }
        }

        public int instrument
        {
            get
            {
                return _instrument;
            }
            set
            {
                _instrument = value;
                foreach (var midEvent in track.Events)
                    if (midEvent.EventType == MidiEventType.ProgramChange)
                        (midEvent as ProgramChangeEvent).ProgramNumber = (Melanchall.DryWetMidi.Common.SevenBitNumber)_instrument;
                MainForm.loadedMid.Chunks[trackIndex] = track;
            }
        }

        public string instrumentName
        {
            get
            {
                if (instrument == -1)
                    return "[NO INSTRUMENT]";
                if (channel != 10)
                    return NLSTUtils.getInstrumentName(MainForm.instance.NLSTChoice, instrument);
                else
                    return NLSTUtils.percussionNames[instrument];
            }
            set
            {

            }
        }

        public midiTrack(int trackIndex, string trackName)
        {
            var chunk = MainForm.loadedMid.Chunks[trackIndex];
            this.trackIndex = trackIndex;
            this.track = (chunk as TrackChunk);
            if (track == null)
                throw new Exception("Not a track???");
            this.trackName = trackName;
            foreach (var midEvent in track.Events)
            {
                if (midEvent.EventType == MidiEventType.ProgramChange) // look for program change event to set channel and instrument
                {
                    _channel = (midEvent as ProgramChangeEvent).Channel;
                    _instrument = (midEvent as ProgramChangeEvent).ProgramNumber;
                    originalInstrument = _instrument;
                }
                if (midEvent.EventType == MidiEventType.SequenceTrackName)
                    this.trackName = (midEvent as SequenceTrackNameEvent).Text;

                if (this.channel != -1 && this.instrument != -1 && !string.IsNullOrEmpty(this.trackName))
                    break;
            }
        }
    }
}
