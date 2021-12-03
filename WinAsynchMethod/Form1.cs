using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsynchMethod
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int x, int y);
        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txbA.Text);
                b = int.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При преобразование типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cd = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cd, summdelegate);
        }
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }
    }
}
