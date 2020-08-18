namespace SM64Mus
{
    internal static class NLSTUtils
    {
        // used sm64 instrument list @ https://docs.google.com/document/d/1WbFM2MeP15NDMhYS9yA2Nv2xQEGljtMuQrWrHtGTWAc/view
        public static readonly string[] NLISTNames = new string[]{
            /*"SFX", // 0
            "SFX, Footsteps", // 1
            "SFX, Water", // 2
            "SFX, Sand(?)",//3
            "SFX", // 4
            "SFX", // 5
            "SFX", // 6
            "SFX, Misc",
            "Mario Voice",
            "SFX",*/
            "SFX, Voices",
            "Snow",
            "[Unused]",
            "Koopa the Quick, Slide levels",
            "Inside the castle walls",
            "Shifting Sand Land/Lethal Lava Land",
            "Haunted House",
            "Title Screen",
            "Bowser Battle",
            "Jolly Roger Bay/Dire Dire Docks",
            "Piranha Plant’s Sleeping Melody",
            "Hazy Maze Cave",
            "Star Select",
            "Wing Cap",
            "Metal Cap",
            "Bowser Course",
            "Fanfares",
            "Boss Fight",
            "Looping Stairs",
            "Finar Bowser Battle",
            "Unknown",
            "Star Catch?",
            "Toad",
            "Ghost Merry-Go-Round",
            "Bob-Omb Battlefield",
            "Unknown",
            "File Select",
            "Ending Credits"
            };

        // same source as above
        public static readonly string[][] instrumentNames = new string[][]
        {/*
            // NLST 0 (SFX) [Sample Rate = 8000hz]
new string[]{"Woosh (Mid-air flip)","Electric sound","Snare Drum?","Yoshi's sound from SMW","Mario Pulling himself out of snow/sand","Ground Pound"},
// NLST 1 (SFX, Footsteps) [Sample Rate = 8000hz]
new string[]{"Click? (Footstep 1?)","Click? (Footstep 2?)","Click? (Footstep 2?)","Hard footstep?","Stepping on wood","Stepping on snow/sand?","Dry footstep?","Metal Mario Footstep","Sand footstep"},
// NLST 2 (SFX, Water) [Sample Rate = 8000hz]
new string[]{"Water Splash (Jumping into water)","Small Water Splash","Waterfall"},

// NLST 3 (SFX, Sand?)
new string[]{"? (Sand?)","? (Shifting sand?)","? (More shifting sand?)","?!","? (Sand step?)","?","??","?","? (falling sand?)","?"},
// NLST 4 (SFX) [Sample Rate = 8000hz]
new string[]{"Warp Sound (Hole/Pipe)","Door Knob","Opening Door","Opening Metal Door","Door closing","Flowing water","Bubble","Bubble","Monty Mole throwing rock?","Door Knob","Door closing?","Door closing?","Door closing?","Thrown out of painting","Star Catch/Warp","Volcano Eruption?"},

// NLST 5 (SFX)
new string[]{"Koopa the Quick Gunshot (for when race starts)","Waterfall?","","Flamethrower?","Opening Door","Clank?","Wind","Destroyed Box","Bird Chirp","Bird Chirp 2","Bird Chirp 3","Bird chirp 4","Bird Chirp 5","Waterfall?","Jumping box","Shining?"},
// NLST 6(SFX)
new string[]{"MIPS The bunny hop","Stomp?","Rawr (Bowser)","Rawr (Bowser)","Bowser death","swoosh (Swinging bowser by his tail)","Bowser inhale (Before exhaling flames)","Baby Penguin","Soft step? (Koopa?)","Boo/modified bowser laugh","Cannon moving sound 1","Cannon moving sound 2","Door Knob","Door Knob","Piranha Plant Dying","Pushing Box"},

// NLST 7 (SFX, misc)
new string[]{"Chirp noise? (Possibly smashing a scuttlebug)","Metal CLing (Metal Mario step?)","Scuttlebug Step","Gunshot (Cannon shot?)","Gunshot (Cannon shot?)","Bowser breathing fire?","Heav-Ho?","Ukiki","Goomba stomp?","Swoop the bat?","Penguin?","Cowbell","ERGH! (Whomp/Thwomp)","Piano Chomping Sound ","Chain Chomp"},

// NLST 8 ("Mario's"// NLST)
new string[]{"Wuh! (Jump)","Wah! (Jump, punch)","Yah! (Jump, Punch)","Haha! (Entering water)","Yah Hoo! (Certain Jumps)","Uh! (Falling off ledge)","Hmph! (Picking up object)","Wah!","Woah! (Grabbing ledge)","eee-yeh! (Climb up ledge)","Ulgh! (Getting hurt by enemy)","Oof!","Here we go! (Star catch, wind floating)","Yawn (After not controlling Mario for a while)","Snore inhale (Sleeping)","Snore exhale (Sleeping)","D'oh! (Hitting wall)","Game Over! (Trollface)","Hello! (Mario Head screen)","Press Start to play! (Mario Head Screen)","Boing! (Spinning jump off of enemies)","Night-Night...Ah Spaghetti... Ah Ravioli... Ah Mama-Mia (Deep sleep)","So long eh bowser! (Tossing Bowser into bomb)","I'm a Tired!","Waha! (Certain Jumps)","Yippee! (Certain Jumps)","Let's a Go!"},
// NLST 9 (SFX)
new string[]{"Electric Piano?","Square Wave-Like piano sound (Modified for pause screen and others)","Electric Piano?","Used for the coin sound, health bar, camera swing and other assorted SFX","ErEr! (Denied Camera Control)","Camera Snapshot sound (Pressing R for camera)","Weird-Boing sound (Stretching Mario's face?)"},
*/
// NLST 10 (SFX, Voices)
new string[]{"WAAAAOOO000ooooOOOOOOo000OooooOOOO","Huh-Hoo!(Double Jump)","Hooh!(Low Health)","Hooh!(Low Health)","Hehh... Oof. (Death)","HAHAHAHAHAHAHAAAAA (Lava/Lethal Ice)","Eh! (Climbing Ledge)","Cough (When in poisonous fog)","Itsa me, Mario!","Ya! (First Jump)","Hoo! (Kick)","Mama mia!","Okey Dokey!","Drowning","Thank you so much'a for'a playing my game!","Peach intro message","Mario! (Peach's voice)","The power of the stars is restored to the castle","And it's all thanks to you!","Thank you, Mario","We have to do something special for you","Listen everybody, let's bake a delicious cake!","For Mario!","Mario! (Peach)"},
// NLST 11 (Snow)
new string[]{"Acoustic Guitar","Accordion","Accordion","Accordion","Accordion","Accordion","French Horn","French Horn","French Horn","French Horn","Cymbal","Jingles"},
// NLST 12 (Unused)
new string[]{"Acoustic Guitar","Acoustic Guitar","Acoustic Guitar","Acoustic Guitar","Acoustic Guitar","Acoustic Guitar","Low Instrument?","Recorder","Recorder","Recorder","Recorder","Crash Cymbal","Snare Drum","Triangle and Cabasa","Triangle and Cabasa","Celesta"},

// NLST 13 (Koopa the Quick, Slide Levels)
new string[]{"Banjo","Banjo","Fiddle","Fiddle","Whistle with vibrato","Piano","Acoustic Bass","Acoustic Bass","Acoustic Bass","Acoustic Bass","Cymbal","Crash Cymbal","Hand Clap and Snare Drum"},
// NLST 14 (Inside Castle Walls)
new string[]{"Strings","Strings","Strings","Pizzicato String","Cello","Electric Piano","Electric Piano"},
// NLST 15 (Shifting Sand Land/Lethal Lava Land)
new string[]{"Percussion Loop","Choir Ooh's","Sitar Drone notes","Sitar"},

// NLST 16 (Haunted House)
new string[]{"Low Haunting Wind","Low Haunting Wind","Low Cowbell","Low Cowbell","High Cowbell","High Cowbell","High Cowbell","High Cowbell","High Cowbell","High Cowbell"},

// NLST 17 (Title Screen)
new string[]{"Drum Machine Kick/Snare Split","Lead 8 (bass+lead)","Lead 8 (bass+lead)","Percussive Organ","Steel Drum","Brass","Slap Bass","Synth Voice","Electric Guitar (Clean)","Electric Guitar (Clean)","Closed/Open Hi-Hat","Crash Cymbal and Ride Cymbal","Snare Drum","Triangle and Cabasa"},

// NLST 18 (Bowser Battle)
new string[]{"Charang (Lead 5)","Overdriven Guitar","Overdriven Guitar","Orchestra Hit","Recorder","Recorder","Strings","Strings","Drum Sample","Drum Sample","Closed/Open Hi-Hat","Crash Cymbal and Ride Cymbal"},
// NLST 19 (Jolly Roger Bay/Dire Dire Docks)
new string[]{"Strings","Strings","Strings","Strings","Strings","Strings","Electric Bass"," Electric Bass","Electric Bass","Electric Bass","Closed/Open Hi-Hat","Crash Cymbal and Ride Cymbal","Crash Cymbal and Ride Cymbal","Crash Cymbal and Ride Cymbal","Electric Piano","Electric Piano"},
// NLST 20 (Piranha Plant’s Sleeping Melody)
new string[]{"Music Box","Music Box","Music Box","Music Box","Music Box"},

// NLST 21 (Hazy Maze Cave)
new string[]{"Melodic Tom","Triangle","Electric Bass","Slap Bass","Electric Bass (same as 2)","Acoustic Steel Guitar","Melodic Tom","Choir Ooh","Choir Ooh","Choir Ooh"},
// NLST 22 (Star Select)
new string[]{"Pah","Pah"},
// NLST 23 (Wing Cap)
new string[]{"Acoustic Bass","Banjo","Strings","Strings","Electric Piano","Electric Piano","Electric Piano","Electric Piano","Electric Piano","Electric Piano","Crash Cymbal","Cymbal","Triangle and Cabasa"},

// NLST 24 (Metal Cap)
new string[]{"Organ","Synth Bass","Saw Wave","Orchestra Hit","Orchestra Hit","Orchestra Hit","Orchestra Hit","Orchestra Hit","Orchestra Hit","Orchestra Hit","Cymbal","Cymbal","Triangle and Cabasa","Orchestral percussion","Drum Machine Kick and Snare split"},

// NLST 25 (Bowser Course)
new string[]{"Choir ooh","Trumpet","Strings","Siltar Drone note","Orchestra Hit","Percussion Loop","Trumpet","Choir ooh","Choir ooh","Choir ooh","Drum Sample","Crash Cymbal","Timpani"},

// NLST 26 (Fanfares)
new string[]{"Trumpet","Cello or low woodwind","French horn","Strings (Low?)","Trumpet","Electric Piano","Electric Piano","Electric Piano","Electric Piano","Electric Piano","Timpani","Crash Cymbal","Drum Sample"},

// NLST 27 (Boss Fight)
new string[]{"Strings","Strings","French Horn","Trumpet","Strings","Strings","Strings","Timpani","Drum Sample","Drum Sample","Cymbal","Crash Cymbal"},
// NLST 28 (Looping Stairs)
new string[]{"Xylophone","Xylophone","Xylophone","Xylophone","Strings","Strings","Strings"},
// NLST 29 (Final Bowser Battle)
new string[]{"Church Organ","Church Organ","Church Organ","Church Organ","Church Organ","Choir ooh"},
// NLST 30 (?)
new string[]{"Acoustic Guitar","Acoustic Guitar","Strings","Strings"},

// NLST 31 (Star Catch?)
new string[]{"Accordion","Accordion","Accordion","Accordion","Accordion","Accordion","Accordion","Accordion","Accordion","Accordion","Accordion","Bells","Snare Drum"},

// NLST 32 (Toad)
new string[]{"French Horn","French Horn","French Horn","French Horn","French Horn","French Horn","French Horn","French Horn","Strings"},
// NLST 33 (Ghost Merry-Go-Round)
new string[]{"Accordion","Accordion","Accordion","Electric piano"},

// NLST 34 (Bob-Omb Battlefield)
new string[]{"Brass","Brass","Brass","Brass","Brass","Brass","Slap Bass","Synth Voice","Electric Guitar (Muted)","Electric Guitar (Muted)","Open/Closed Hi-Hat","Crash Cymbal and Ride Cymbal"},

// NLST 35 (?)
new string[]{"Strings","Strings","Strings","Strings","Strings","Electric Piano","Electric Piano","Acoustic Guitar"},
// NLST 36 (File Select)
new string[]{"Pan Flute","Pan Flute","Strings","Choir Ooh","Choir Ooh","Choir Ooh","Choir Ooh","Choir Ooh","Choir Ooh","Choir Ooh"},

// NLST 37 (Credits)
new string[]{"Accordion","Slap Bass","Electric Guitar (Jazz)","Electric Piano","Grand Piano","French Horn","Pan Flute","Strings","Electric Piano","Electric Piano","Closed/Open Hi-Hat","Crash Cymbal and Ride Cymbal","Triangle and Cabasa","Triangle and Cabasa","Accordion","Grand Piano"}
        };

        // used SM64 Percussion guide @ https://docs.google.com/document/d/10eKfnE4FiwcZe1_bnXtK4rl7FLjL_vMz2SfTLZW-0hY/view
        public static readonly string[] percussionNames = new string[]
        {
            "Kick Drum", // 1
            "Kick Drum +1",
            "Kick Drum +2",
            "Kick Drum +3",
            "Kick Drum +4",
            "Kick Drum +5",
            "Kick Drum +6",
            "Kick Drum +7",
            "Kick Drum +8",
            "Kick Drum +9", // 10
            "Kick Drum +10",
            "Kick Drum +11",
            "Kick Drum +12",
            "Kick Drum +13",
            "Kick Drum +14",
            "Kick Drum +15",
            "Kick Drum +16",
            "Kick Drum +17",
            "Kick Drum +18",
            "Kick Drum +19", // 20
            "Kick Drum +20",
            "Kick Drum +21",
            "Kick Drum +22",
            "Kick Drum +23",
            "Kick Drum +24",
            "Kick Drum +25",
            "Kick Drum +26",
            "Kick Drum +27",
            "Kick Drum +28",
            "Kick Drum +29", // 30
            "Kick Drum +30",
            "Kick Drum +31",
            "Kick Drum +32",
            "Kick Drum +33",
            "Kick Drum +34",
            "Kick Drum +35", // 36
            "Kick Drum +36",
            "Drum Stick",
            "Snare",
            "Snare",
            "Snare",
            "Tom Drum",
            "Tom Drum +1",
            "Tom Drum +2",
            "Tom Drum +3",
            "Tom Drum +4",
            "Tom Drum +5",
            "Tom Drum +6",
            "Tom Drum +7",
            "Tom Drum +8",
            "Tom Drum +9",
            "Tom Drum +10",
            "Tom Drum +11",
            "Tom Drum +12",
            "Tambourine",
            "Tambourine +1",
            "Tambourine +2",
            "Tambourine +3",
            "Tambourine +4",
            "Tambourine +5",
            "Tambourine +6",
            "Tambourine +7",
            "Low Bongo",
            "Low Bongo +1",
            "Low Bongo +2",
            "Low Bongo +3",
            "Low Bongo +4",
            "Low Bongo +5",
            "Low Bongo +6",
            "Low Bongo +7",
            "High Bongo",
            "High Bongo +1",
            "Conga",
            "Conga +1",
            "Conga +2",
            "Conga +3",
            "Conga +4",
            "Conga +5",
            "Conga +6",
            "Conga +7",
            "Conga +8",
            "Conga +9",
            "Conga +10",
            "Conga +11",
            "Claves",
        };
        public static string getNLSTName(int nlst)
        {
            return "NIST " + nlst + ": " + NLISTNames[nlst];
        }

        public static string getInstrumentName(int nlst, int instrument)
        {
            if (instrument > 27)
                return "[" + instrument + "]";
            return "["+instrument+"] "+instrumentNames[nlst][instrument];
        }
    }
}