# SM64Mus

![Icon](icon.png?raw=true)

## Easy conversion of MIDI to .m64 for SM64 romhacking

A quick tool I put together to make sm64 music making easier.
Keep in mind the code isn't the best due to putting this together in a short amount of time for personal use. There's also quite a few of bugs.

I don't have much time to be working on the project, but PRs are welcome!

Libraries/Projects used:

* A [fork](https://github.com/dylanpdx/m64lab) of [m64lab](https://github.com/DotStarMoney/m64lab) that properly assigns instruments, and is bundled as a library. This is used to convert the midi to .m64
* [FluidSynth](https://github.com/FluidSynth/fluidsynth) and [NFluidSynth](https://github.com/atsushieno/nfluidsynth) - For preview mode
* [DryWetMidi](https://github.com/melanchall/drywetmidi) for midi parsing
* [ObjectListView](https://www.myget.org/feed/geomatics/package/nuget/ObjectListView.Official) for displaying channels

## Using

Load a MIDI file, select the soundbank the final sound will be played on, and then select the proper instruments for each channel.

## Using Preview mode
Please note that preview mode is NOT perfect, and the final result can sound much different in-game (due to N64 limits, converter errors, etc.)

To use Preview mode, you need a legally ripped N64 ROM, and the N64 Soundbank Tool from [this repository](https://github.com/jombo23/N64-Tools).
Select your ROM in the N64 Soundbank tool, load it, and then press the "Write All DLS Soundfont Banks" button.
Browse to the folder where SM64Mus is, and select or create the "Soundbanks" folder. Export your soundbanks there.

Pressing play in SM64Mus with a MIDI loaded should now load and play the midi with the SM64 soundbank selected.

Changing instruments or soundbanks should refresh the preview live.

## Building

Build instructions coming soon

## TODO

* Implement a m64 converter within the tool itself
* Check for overlapping notes & offer to move to a new channel