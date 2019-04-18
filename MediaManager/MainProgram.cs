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
    public partial class MainProgram : Form
    {
        private FileManager t1;
        public MainProgram(FileManager t1)
        {
            this.t1 = t1;
            InitializeComponent();
        }

        private void MainProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(System.Windows.Forms.Application.MessageLoop)
            {                
                System.Windows.Forms.Application.Exit();
            }
            else
            {                
                System.Environment.Exit(1);
            }
        }
    }
}
