using System;
using System.Windows.Forms;

namespace lesson2firstProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void msgLabel_Click(object sender, EventArgs e)
        {
            // number of people in a cafe
            ushort numberPeople = 34;
            // $ used for string interpolation
            // variable names can be put into strings with curly braces
            msgLabel.Text = $"Number of people: {numberPeople}\n";
            numberPeople = 23; // reassign
            msgLabel.Text += $"Number of people: {numberPeople}";
        }
    }
}
