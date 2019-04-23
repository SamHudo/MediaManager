using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaManager.Details
{
    public class MediaFiles
    {
        public ShellFile file;

        public MediaFiles(string path)
        {
            this.Path = path;
            file = ShellFile.FromFilePath(path);
        }

        public string Path { get; set; }

        public string Title
        {
            get { return file.Properties.System.Title.Value; }
            set { file.Properties.System.Title.Value = value; }
        }
        public ulong? Size
        {
            get { return file.Properties.System.Size.Value; }
            set { file.Properties.System.Size.Value = value; }
        }
        public string FileName
        {
            get { return file.Properties.System.FileName.Value; }
            set { file.Properties.System.FileName.Value = value; }
        }
        public DateTime? DateCreated
        {
            get {
                return file.Properties.System.DateCreated.Value;
            }
            set { file.Properties.System.DateCreated.Value = value; }
        }
        public DateTime? DateModified
        {
            get { return file.Properties.System.DateModified.Value; }
            set { file.Properties.System.DateModified.Value = value; }
        }
    }
}
