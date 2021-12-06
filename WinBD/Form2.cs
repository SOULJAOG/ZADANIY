using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataView ПоставщикиDataView;
        BindingSource sotrBindingSourse;
        private void button1_Click(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            ПоставщикиDataView = new
            DataView(rbProductDataSet1.Поставщики);
            dataGridView1.DataSource = ПоставщикиDataView;
            ПоставщикиDataView.Sort = "Поставщик";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ПоставщикиDataView.Sort = SortTextBox.Text;
            ПоставщикиDataView.RowFilter = FilterTextBox.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            sotrBindingSourse = new BindingSource(rbProductDataSet1, "Поставщики");
            FamtextBox.DataBindings.Add("Text", sotrBindingSourse, "Поставщик");
            NametextBox.DataBindings.Add("Text",sotrBindingSourse, "Адрес поставщика");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSourse, "Телефон");
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }
    }
}
