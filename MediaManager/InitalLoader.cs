using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaManager
{
    public partial class InitalLoader : Form
    {
        private FileManager t1 = new FileManager();

        public InitalLoader()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            BackboneWorker.RunWorkerAsync();
        }

        private void InitializeBackgroundWorker()
        {
            BackboneWorker.DoWork += new DoWorkEventHandler(BackboneWorker_DoWork);
            BackboneWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackboneWorker_RunWorkerCompleted);
            BackboneWorker.ProgressChanged += new ProgressChangedEventHandler(BackboneWorker_ProgressChanged);
        }

        private void BackboneWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            t1.ScanFileLocations(worker, e);
            e.Result = "Done File Scan";
        }

        private void ProgressUpdate(int value, string Reason)
        {
            base.Invoke((Action)delegate
            {
                Progresslbl.Text = "Part: " + value + " of " + Reason;
                InitalProgressBar.Increment(1);
            });
        }

        private void BackboneWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                InitalProgressBar.Value = 0;
                Progresslbl.Text = "Canceled!";
            }
            else if (e.Error != null)
            {                
                Progresslbl.Text = "Error: " + e.Error.Message;
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                InitalProgressBar.Value = 100;
                Progresslbl.Text = "Done!";
                MainProgram main = new MainProgram(t1); 
                this.Hide();                
                main.Show();
            }
        }

        private void BackboneWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.InitalProgressBar.Value = e.ProgressPercentage;
            InitalProgressBar.Increment(1);
        }
    }
}
