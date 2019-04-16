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
        public InitalLoader()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitalProgressBar.Increment(1);
            Progresslbl.Text = InitalProgressBar.Value.ToString() + "%";
        }


    }
}
