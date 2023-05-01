using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortCalc
{
    public partial class Form4 : Form
    {
        private int NumAccrual;
        private decimal Upb;
        private List<decimal[]> Payments;
        private static List<string[]> AmortizationTable;
        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            NumAccrual = 12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv|*.csv";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            dataGridView1.Rows.Clear();
            Payments = Util.ReadFile(openFileDialog.FileName);
            foreach (decimal[] i in Payments)
            {
                dataGridView1.Rows.Add(i[0], i[1]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NumAccrual = 12;
                    break;
                case 1:
                    NumAccrual = 1;
                    break;
                case 2:
                    NumAccrual = 4;
                    break;
                case 3:
                    NumAccrual = 365;
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Upb = numericUpDown1.Value;
        }
        public static List<string[]> GetAmortizationTable()
        {
            return AmortizationTable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AmortizationTable = Util.CalculateVariable(Upb, NumAccrual, Payments);
            if (AmortizationTable == null)
            {
                MessageBox.Show("付款历史不得为空");
                return;
            }
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
