using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text) || String.IsNullOrEmpty(secoundNumberTextBox.Text))
            {
                MessageBox.Show("Please Fill Up Both of the Text Box First");
            }

            else
            {
                double firstNumber = Convert.ToInt16(firstNumberTextBox.Text);
                double secoundNumber = Convert.ToInt16(secoundNumberTextBox.Text);

                double result = firstNumber + secoundNumber;

                showResultBox.Text = Convert.ToString(result);
            }

        }

        private void subNumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text) || String.IsNullOrEmpty(secoundNumberTextBox.Text))
            {
                MessageBox.Show("Please Fill Up Both of the Text Box First");
            }

            else
            {
                double firstNumber = Convert.ToInt16(firstNumberTextBox.Text);
                double secoundNumber = Convert.ToInt16(secoundNumberTextBox.Text);

                double result = firstNumber - secoundNumber;

                showResultBox.Text = Convert.ToString(result);
            }

        }

        private void mulNumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text) || String.IsNullOrEmpty(secoundNumberTextBox.Text))
            {
                MessageBox.Show("Please Fill Up Both of the Text Box First");
            }

            else
            {
                double firstNumber = Convert.ToInt16(firstNumberTextBox.Text);
                double secoundNumber = Convert.ToInt16(secoundNumberTextBox.Text);

                double result = firstNumber * secoundNumber;

                showResultBox.Text = Convert.ToString(result);
            }

        }

        private void divNumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text) || String.IsNullOrEmpty(secoundNumberTextBox.Text))
            {
                MessageBox.Show("Please Fill Up Both of the Text Box First");
            }

            else
            {
                double firstNumber = Convert.ToInt16(firstNumberTextBox.Text);
                double secoundNumber = Convert.ToInt16(secoundNumberTextBox.Text);


                if (secoundNumber==0)
                {
                    MessageBox.Show("We Can,t devide Any number with '0'");
                }
                else
                {
                    double result = firstNumber / secoundNumber;

                    showResultBox.Text = Convert.ToString(result);
                  

                }

                
            }

        }
    }
}
