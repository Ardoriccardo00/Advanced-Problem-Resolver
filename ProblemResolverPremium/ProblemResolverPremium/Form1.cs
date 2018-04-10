using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemResolverPremium
{
    public partial class Form1 : Form
    {
        int Timer;
        string FileName;
        string IP;

        public Form1()
        {
            InitializeComponent();
        }

        private void setATimerForShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textTimer.Visible = true;
            //Timer = int.Parse(textTimer.Text);
            //MessageBox.Show(Convert.ToString(Timer));


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer = int.Parse(textTimer.Text);
            MessageBox.Show(Convert.ToString(Timer));
            System.Diagnostics.Process.Start("shutdown", "/r /t Timer");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
        }
    }
}
