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
using System.Net.NetworkInformation;

namespace ProblemResolverPremium
{
    public partial class Form1 : Form
    {
        int Timer;
        string FileName;
        string IP;
        string ping;
        int contatore = 0;
        string Delet;

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
            Counter.Enabled = true;
            FileName = textBox3.Text;

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
            Counter.Enabled = false;
        }

        private void Counter_Tick(object sender, EventArgs e)
        {
            contatore = contatore + 1;
            DataTimer.Text = (Convert.ToString(contatore));
            if (contatore == int.Parse(textTimer.Text)) { System.Diagnostics.Process.Start("shutdown", "/r /t 1"); }
        }

        private void pingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {




            
        }

        private void ipFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process test = new Process();
            //test.StartInfo.FileName = "ipconfig";
            //test.StartInfo.UseShellExecute = false;
            //test.StartInfo.Arguments = "/all";
            //test.StartInfo.RedirectStandardOutput = true;
            //test.Start();
            //textBox1.Visible = true;
            //textBox1.Text =
            //test.StandardOutput.ReadToEnd();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pinging = false;
            Ping isPing = new Ping();
            try
            {
                PingReply reply = isPing.Send(textPing.Text);
                pinging = reply.Status == IPStatus.Success;
            }
            catch (PingException) { }
            MessageBox.Show("" + pinging, "title");
        }

        private void findYourInternetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IP f2 = new IP();
            f2.Show();
        }

        private void typeAWebsiteAndTestYourPingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            textPing.Visible = true;
            button1.Visible = true;
            textBox2.Visible = true;
        }

        private void typeTheFileDirectoryToDeleteItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox3.Visible = true;
           
        }
       

        private void delet_Click(object sender, EventArgs e)
        {
            Delet = delet.Text;
        }
    }
}
