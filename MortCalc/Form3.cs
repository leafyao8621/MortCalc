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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string[]> AmortizationTable = Form2.GetAmortizationTable();
            textBox1.Text =
                $"{AmortizationTable.Count()}期后的余额为{AmortizationTable.Last()[1]:0.##}";
            foreach (string[] i in AmortizationTable)
            {
                dataGridView1.Rows.Add(i);
            }
        }
    }
}
