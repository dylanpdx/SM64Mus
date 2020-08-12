using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Mus
{
    static class fluidSynthExtras
    {
        /// <summary>
        /// Seeks the player to a specified tick
        /// http://www.fluidsynth.org/api/midi_8h.html#a06660e3217c6c4a14bd55951b4a86d94
        /// </summary>
        /// <param name="player">handle to the player</param>
        /// <param name="tick">tick to seek to</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("fluidsynth.dll")]
        public static extern int fluid_player_seek(IntPtr player, int tick);
    }
}
