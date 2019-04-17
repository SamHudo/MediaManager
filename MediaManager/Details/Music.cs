using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaManager.Details
{
    class Music : MediaFiles
    {
        public Music(string path): base(path)
        {

        }

        public string AlbumTitle
        {
            get { return file.Properties.System.Music.AlbumTitle.Value; }
            set { file.Properties.System.Music.AlbumTitle.Value = value; }
        }

        public string AlbumArtist
        {
            get { return file.Properties.System.Music.AlbumArtist.Value; }
            set { file.Properties.System.Music.AlbumArtist.Value = value; }
        }

        public string[] Artists
        {
            get { return file.Properties.System.Music.Artist.Value; }
            set { file.Properties.System.Music.Artist.Value = value; }
        }

        public string Artist
        {
            get { return file.Properties.System.Music.DisplayArtist.Value; }
            set { file.Properties.System.Music.DisplayArtist.Value = value; }
        }

        public string[] Genre
        {
            get { return file.Properties.System.Music.Genre.Value; }
            set { file.Properties.System.Music.Genre.Value = value; }
        }

        public string Mood
        {
            get { return file.Properties.System.Music.Mood.Value; }
            set { file.Properties.System.Music.Mood.Value = value; }
        }

        public uint? TrackNumber
        {
            get { return file.Properties.System.Music.TrackNumber.Value; }
            set { file.Properties.System.Music.TrackNumber.Value = value; }
        }

        public string BeatsPerMinute
        {
            get { return file.Properties.System.Music.BeatsPerMinute.Value; }
            set { file.Properties.System.Music.BeatsPerMinute.Value = value; }
        }       

    }
}
