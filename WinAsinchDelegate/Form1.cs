using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsinchDelegate
{
    public partial class Form1 : Form
    {
        private delegate void TineConsumingMethodDelegate(int second);
        private delegate void SetProgressDelegate(int val);
        public void SetProgress(int val) { 
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void TineConsumingMethod(int second)
        {
            for (int j = 1; j <= second; j++)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
