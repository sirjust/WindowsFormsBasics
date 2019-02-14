using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson2firstProgram
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string seaColor = "blue";
            int forests = 2;
            bool hasCities = true;
            // decimal can store monetary datatypes
            decimal mapPrice = 0.99M;
            double mapHeight = 35.0;

            label1.Text = $"Sea Color: {seaColor}\nForests: {forests}\nThere are cities on this continent(T/F): {hasCities}\nMap Price: {mapPrice}\nMap Height: {mapHeight}";
        }
    }
}
