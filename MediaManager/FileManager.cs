using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaManager
{
    class FileManager
    {
        public FileManager(String path)
        {
            var file = ShellFile.FromFilePath(path);
            
        }
    }
}
