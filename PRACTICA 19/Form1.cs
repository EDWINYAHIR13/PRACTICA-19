namespace PRACTICA_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(textBox1.Text);
            cal = double.Parse(textBox2.Text);
            cal = double.Parse(textBox3.Text);
            cal = double.Parse(textBox4.Text);

            if (cal >= 6) MessageBox.Show(" APROBADO "); else MessageBox.Show(" REPROBADO ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}