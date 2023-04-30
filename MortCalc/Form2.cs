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
    public partial class Form2 : Form
    {
        private static int NumAccrual;
        private static decimal Upb;
        private static decimal Rate;
        private static int Period;
        private static decimal Payment;
        private static List<string[]> AmortizationTable;
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            NumAccrual = 12;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmortizationTable = Util.Calculate(Upb, Rate, Period, Payment);
            Form3 form3 = new Form3();
            form3.Show();
        }
        public static List<string[]> GetAmortizationTable()
        {
            return AmortizationTable;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            Upb = numericUpDown5.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Rate = numericUpDown2.Value / NumAccrual / 100;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Period = Convert.ToInt32(numericUpDown3.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Payment = numericUpDown4.Value;
        }
    }
}
