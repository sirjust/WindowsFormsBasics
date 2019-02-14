using System;
using System.Windows.Forms;

namespace lesson2firstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Form3 form3 = new Form3();
            form3.Show();
            msgLabel.Text = "Hello world!";

        }
    }
}
