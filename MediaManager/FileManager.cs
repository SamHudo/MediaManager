using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaManager.Details;
using System.Text.RegularExpressions;
using System.IO;
using System.ComponentModel;

namespace MediaManager
{
    public class FileManager
    {
        public List<MediaFiles> MediaFiles { get; set; }
        public List<Music> MusicFiles { get; set; }
        public List<Video> VideoFiles { get; set; }

        public FileManager()
        {
            MediaFiles = new List<MediaFiles>();
            MusicFiles = new List<Music>();
            VideoFiles = new List<Video>();
        }


        public void ScanFileLocations(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    int highestPercentageReached = 0;
                    foreach (var file in FileLocations)
                    {
                        int percentComplete = (int)((float)Array.IndexOf(FileLocations, file) / (float)Array.LastIndexOf(FileLocations, file) * 100);
                        if (percentComplete > highestPercentageReached)
                        {
                            highestPercentageReached = percentComplete;
                            worker.ReportProgress(percentComplete);
                        }
                        foreach (var ext in MusicExt)
                        {

                            string[] filePaths = Directory.GetFiles(file, ext, SearchOption.AllDirectories);
                            foreach (var files in filePaths)
                            {
                                MusicFiles.Add(new Music(files));

                            }
                        }
                        foreach (var ext in VideoExt)
                        {

                            string[] filePaths = Directory.GetFiles(file, ext, SearchOption.AllDirectories);
                            foreach (var files in filePaths)
                            {
                                VideoFiles.Add(new Video(files));

                            }
                        }
                        foreach (var ext in OtherExt)
                        {

                            string[] filePaths = Directory.GetFiles(file, ext, SearchOption.AllDirectories);
                            foreach (var files in filePaths)
                            {
                                MediaFiles.Add(new MediaFiles(files));

                            }
                        }
                    }
                }
                catch (Exception exc)
                {
                    throw new ArgumentException(exc.ToString());
                }
            }

        }

        public string[] MusicExt {
            get
            {
                return ManagerSettings.Default.MusicFileExt.Split(',');
            }
            set
            {
                ManagerSettings.Default.MusicFileExt = string.Join(",",value);
            }
        }

        public string[] FileLocations
        {
            get
            {
                return ManagerSettings.Default.FileLocations.Split(new string[] { "/r/n" }, StringSplitOptions.None);
            }
            set
            {
                ManagerSettings.Default.FileLocations = string.Join("/r/n", value);
            }
        }

        public string[] VideoExt
        {
            get
            {
                return ManagerSettings.Default.VideoFileExt.Split(',');
            }
            set
            {
                ManagerSettings.Default.VideoFileExt = string.Join(",", value);
            }
        }

        public string[] OtherExt
        {
            get
            {
                return ManagerSettings.Default.OtherFileExt.Split(',');
            }
            set
            {
                ManagerSettings.Default.OtherFileExt = string.Join(",", value);
            }
        }

        public List<string> MusicOrder
        {
            get
            {
                return ManagerSettings.Default.OrderOfMusic.Split(',').ToList();
            }
            set
            {
                ManagerSettings.Default.OrderOfMusic = string.Join(",", value.ToArray());
            }
        }

        public void AddMusicOrderCatagory(int index, string catagory)
        {
            List<string> Temp = MusicOrder;
            Temp.Insert(index, catagory);
            MusicOrder = Temp;
        }
        public void AddMusicOrderCatagory(string catagory)
        {
            List<string> Temp = MusicOrder;
            Temp.Add(catagory);
            MusicOrder = Temp;
        }
        public void RemoveMusicOrderCatagory(string catagory)
        {
            List<string> Temp = MusicOrder;
            Temp.Remove(catagory);
            MusicOrder = Temp;
        }

        public List<string> VideoOrder
        {
            get
            {
                return ManagerSettings.Default.OrderOfVideo.Split(',').ToList();
            }
            set
            {
                ManagerSettings.Default.OrderOfVideo = string.Join(",", value.ToArray());
            }
        }

        public void AddOrderOfVideoCatagory(int index, string catagory)
        {
            List<string> Temp = VideoOrder;
            Temp.Insert(index, catagory);
            VideoOrder = Temp;
        }
        public void AddOrderOfVideoCatagory(string catagory)
        {
            List<string> Temp = VideoOrder;
            Temp.Add(catagory);
            VideoOrder = Temp;
        }
        public void RemoveOrderOfVideoCatagory(string catagory)
        {
            List<string> Temp = VideoOrder;
            Temp.Remove(catagory);
            VideoOrder = Temp;
        }

        public List<string> OtherOrder
        {
            get
            {
                return ManagerSettings.Default.OrderOfOther.Split(',').ToList();
            }
            set
            {
                ManagerSettings.Default.OrderOfOther = string.Join(",", value.ToArray());
            }
        }

        public void AddOtherOrderCatagory(int index, string catagory)
        {
            List<string> Temp = OtherOrder;
            Temp.Insert(index, catagory);
            OtherOrder = Temp;
        }
        public void AddOtherOrderCatagory(string catagory)
        {
            List<string> Temp = OtherOrder;
            Temp.Add(catagory);
            OtherOrder = Temp;
        }
        public void RemoveOtherOrderCatagory(string catagory)
        {
            List<string> Temp = OtherOrder;
            Temp.Remove(catagory);
            OtherOrder = Temp;
        }
    }
}
