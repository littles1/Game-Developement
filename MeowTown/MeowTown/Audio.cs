using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeowTown
{
    class Audio
    {
        private static ContentManager _content;
        private static Song _song;
        private static Audio _audio;

        public static void Load()
        {

            //_audio = _content.Load<SoundEffect>("MeowTownSong");
            //_audio.Play();
            _content = Game1.ContentRoot;
            _song = _content.Load<Song>("Sound/MeowTownSong");

            MediaPlayer.Play(_song);
            MediaPlayer.IsRepeating = true;
        }
    }
}
