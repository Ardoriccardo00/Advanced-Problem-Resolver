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

            System.Diagnostics.Process.Start("shutdown","/s /t 100");

            //Process test = new Process();
            //test.StartInfo.FileName = "ipconfig";
            //test.StartInfo.UseShellExecute = false;
            //test.StartInfo.Arguments = "/all";
            //test.StartInfo.RedirectStandardOutput = true;
            //test.Start();
            //textBox1.Text = test.StandardOutput.ReadToEnd();

        }
    }
}
