namespace MortCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.FormClosed +=
                new FormClosedEventHandler(
                    (object sender, FormClosedEventArgs e) =>
                    {
                        Show();
                    }
                );
            form2.Show();
        }
    }
}