namespace SM64Mus
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.channelsGrid = new BrightIdeasSoftware.ObjectListView();
            this.trackName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.channel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.trackInstrument = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NLSTChoices = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMIDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savem64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundControlsPanel = new System.Windows.Forms.Panel();
            this.soundbankPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.soundControlsPanel.SuspendLayout();
            this.soundbankPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.channelsGrid);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 289);
            this.panel1.TabIndex = 0;
            // 
            // channelsGrid
            // 
            this.channelsGrid.AllColumns.Add(this.trackName);
            this.channelsGrid.AllColumns.Add(this.channel);
            this.channelsGrid.AllColumns.Add(this.trackInstrument);
            this.channelsGrid.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.channelsGrid.CellEditUseWholeCell = false;
            this.channelsGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackName,
            this.channel,
            this.trackInstrument});
            this.channelsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.channelsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelsGrid.HideSelection = false;
            this.channelsGrid.Location = new System.Drawing.Point(0, 0);
            this.channelsGrid.Name = "channelsGrid";
            this.channelsGrid.Size = new System.Drawing.Size(476, 285);
            this.channelsGrid.TabIndex = 0;
            this.channelsGrid.UseCompatibleStateImageBehavior = false;
            this.channelsGrid.View = System.Windows.Forms.View.Details;
            this.channelsGrid.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.channelsGrid_CellEditFinishing);
            this.channelsGrid.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.channelsGrid_CellEditStarting);
            // 
            // trackName
            // 
            this.trackName.AspectName = "trackName";
            this.trackName.Groupable = false;
            this.trackName.IsEditable = false;
            this.trackName.Sortable = false;
            this.trackName.Text = "Track Name";
            this.trackName.Width = 91;
            // 
            // channel
            // 
            this.channel.AspectName = "channel";
            this.channel.Text = "Channel";
            // 
            // trackInstrument
            // 
            this.trackInstrument.AspectName = "instrumentName";
            this.trackInstrument.Groupable = false;
            this.trackInstrument.Sortable = false;
            this.trackInstrument.Text = "Instrument";
            this.trackInstrument.Width = 173;
            // 
            // NLSTChoices
            // 
            this.NLSTChoices.FormattingEnabled = true;
            this.NLSTChoices.Location = new System.Drawing.Point(71, 2);
            this.NLSTChoices.Name = "NLSTChoices";
            this.NLSTChoices.Size = new System.Drawing.Size(121, 21);
            this.NLSTChoices.TabIndex = 1;
            this.NLSTChoices.SelectedIndexChanged += new System.EventHandler(this.NLSTChoices_SelectedIndexChanged);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(3, 3);
            this.playButton.Name = "playButton";
            this.playButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(84, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Soundbank:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMIDIToolStripMenuItem,
            this.savem64ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadMIDIToolStripMenuItem
            // 
            this.loadMIDIToolStripMenuItem.Name = "loadMIDIToolStripMenuItem";
            this.loadMIDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadMIDIToolStripMenuItem.Text = "Load MIDI";
            this.loadMIDIToolStripMenuItem.Click += new System.EventHandler(this.loadMIDIToolStripMenuItem_Click);
            // 
            // savem64ToolStripMenuItem
            // 
            this.savem64ToolStripMenuItem.Name = "savem64ToolStripMenuItem";
            this.savem64ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savem64ToolStripMenuItem.Text = "Save .m64";
            this.savem64ToolStripMenuItem.Click += new System.EventHandler(this.savem64ToolStripMenuItem_Click);
            // 
            // soundControlsPanel
            // 
            this.soundControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundControlsPanel.Controls.Add(this.playButton);
            this.soundControlsPanel.Controls.Add(this.stopButton);
            this.soundControlsPanel.Location = new System.Drawing.Point(12, 354);
            this.soundControlsPanel.Name = "soundControlsPanel";
            this.soundControlsPanel.Size = new System.Drawing.Size(480, 31);
            this.soundControlsPanel.TabIndex = 6;
            // 
            // soundbankPanel
            // 
            this.soundbankPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundbankPanel.Controls.Add(this.label1);
            this.soundbankPanel.Controls.Add(this.NLSTChoices);
            this.soundbankPanel.Location = new System.Drawing.Point(12, 27);
            this.soundbankPanel.Name = "soundbankPanel";
            this.soundbankPanel.Size = new System.Drawing.Size(480, 29);
            this.soundbankPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 397);
            this.Controls.Add(this.soundbankPanel);
            this.Controls.Add(this.soundControlsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SM64Mus";
            this.Icon = Properties.Resources.icon;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.channelsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.soundControlsPanel.ResumeLayout(false);
            this.soundbankPanel.ResumeLayout(false);
            this.soundbankPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BrightIdeasSoftware.ObjectListView channelsGrid;
        private BrightIdeasSoftware.OLVColumn trackName;
        private BrightIdeasSoftware.OLVColumn trackInstrument;
        private BrightIdeasSoftware.OLVColumn channel;
        private System.Windows.Forms.ComboBox NLSTChoices;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMIDIToolStripMenuItem;
        private System.Windows.Forms.Panel soundControlsPanel;
        private System.Windows.Forms.Panel soundbankPanel;
        private System.Windows.Forms.ToolStripMenuItem savem64ToolStripMenuItem;
    }
}

