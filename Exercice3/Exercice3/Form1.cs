using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        Calculator calculator;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            calculator = new Calculator(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text));
            txtResult.Text = (calculator.NB1 + calculator.NB2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDiviser_Click(object sender, EventArgs e)
        {
            calculator = new Calculator(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text));
            txtResult.Text = (calculator.NB1 / calculator.NB2).ToString();
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            calculator = new Calculator(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text));
            txtResult.Text = (calculator.NB1 * calculator.NB2).ToString();
        }

        private void btnSoustraire_Click(object sender, EventArgs e)
        {
            calculator = new Calculator(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text));
            txtResult.Text = (calculator.NB1 - calculator.NB2).ToString();
        }
    }
}
