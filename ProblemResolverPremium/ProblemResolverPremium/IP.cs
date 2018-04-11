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

namespace ProblemResolverPremium
{
    public partial class IP : Form
    {
        public IP()
        {
            InitializeComponent();
        }

        private void IP_Load(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "ipconfig";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/all";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Visible = true;
            textBox1.Text =
            test.StandardOutput.ReadToEnd();
        }
    }
}
