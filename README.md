# SM64Mus
## Easy conversion of MIDI to .m64 for SM64 romhacking

A quick tool I put together to make sm64 music making easier.
Keep in mind the code isn't the best due to putting this together in a short amount of time. PRs are welcome!

Libraries/Projects used:

* A [fork](https://github.com/dylanpdx/m64lab) of [m64lab](https://github.com/DotStarMoney/m64lab) that properly assigns instruments, and is bundled as a library.
* [FluidSynth](https://github.com/FluidSynth/fluidsynth) and [NFluidSynth](https://github.com/atsushieno/nfluidsynth) - For preview mode
* [DryWetMidi](https://github.com/melanchall/drywetmidi) for midi parsing
* [ObjectListView](https://www.myget.org/feed/geomatics/package/nuget/ObjectListView.Official) for displaying channels

## Using Preview mode
Please note that preview mode is NOT perfect, and the final result can sound much different in-game (due to N64 limits, converter errors, etc.)

Setup instructions coming soon

## Building

Build instructions coming soon

## TODO

* Implement a m64 converter within the tool itself
* Check for overlapping notes & offer to move to a new channel