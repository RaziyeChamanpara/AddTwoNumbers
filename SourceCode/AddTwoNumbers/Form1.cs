using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //test change in master branch
            int number1, number2;
            try
            {
                
                if (number1TextBox.Text == "" || number2TextBox.Text == "")
                {
                    MessageBox.Show("Enter a number");
                    return;
                }
                
                if (int.TryParse(number1TextBox.Text, out number1)==false || 
                    int.TryParse(number2TextBox.Text, out number2)==false)

                    MessageBox.Show("Number is not in correct format.");
                
                else
                    SumTextBox.Text = (number1 + number2).ToString();

            }
            //learning develop branch
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void number1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
