using System;
using System.Windows.Forms;

namespace MyTest
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Hello, world!";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool isNumber1 = int.TryParse(txtNumber1.Text, out int number1);
            bool isNumber2 = int.TryParse(txtNumber2.Text, out int number2);

            if (isNumber1 == false)
            {
                txtResult.Text = "Sorry, need numbers!";
            }
            else if (isNumber2 == false) {
                txtResult.Text = "Sorry, need numbers!";
            }
            else
            {
                txtResult.Text = Convert.ToString(number1 + number2);
            }


         
        }
    }
}
