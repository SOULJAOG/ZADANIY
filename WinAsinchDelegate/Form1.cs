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
        private delegate void TimeConsumingMethodDelegate(int second);
        private delegate void SetProgressDelegate(int val);
        bool Cansel;
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
        private void TimeConsumingMethod(int second)
        {
            for (int j = 1; j <= second; j++)
            {
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(j * 100) / second);
                if (Cansel) {
                    break;
                }
            }
            if (Cansel)
            {
                System.Windows.Forms.MessageBox.Show("Conselled");
                Cansel = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(textBox1.Text), null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cansel = true;
        }
    }
}
