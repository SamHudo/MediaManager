using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaManager.Details
{
    public class Video : MediaFiles
    {
        public Video(string file): base(file)
        {

        }

        public string[] Director
        {
            get { return file.Properties.System.Video.Director.Value; }
            set { file.Properties.System.Video.Director.Value = value; }
        }

        public uint? VerticalAspectRatio
        {
            get { return file.Properties.System.Video.VerticalAspectRatio.Value; }
            set { file.Properties.System.Video.VerticalAspectRatio.Value = value; }
        }

        public string Compression
        {
            get { return file.Properties.System.Video.Compression.Value; }
            set { file.Properties.System.Video.Compression.Value = value; }
        }
    }
}
