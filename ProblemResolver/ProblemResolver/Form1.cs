using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;



namespace ProblemResolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown","/r /t 10");
            button1.Visible = true;
            MessageBox.Show("We are currently resolving your problems, in 10 seconds your computer is going to shutdown, press the emergency button to stop the process.");
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just close all your programs and let the APS do it's job.");
        }

        private void whatDoesAPSStandsForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advanced problem resolver, DUH...");
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can donate some dogecoins @ DLL5orKG1eNJ7omGvcjaJkEi9jq9a2o6Ce ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Ardoriccardo00");
            }
            catch { }
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
