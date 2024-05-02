using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // function for btn "0"
        private void btn_zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

       // function for btn "1" 
        private void btn_one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        // function for btn "2"
        private void btn_two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
            textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        //function for btn "3"
        private void btn_three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        // function for btn "4"
        private void btn_four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        
        // function for btn "5"
        private void btn_five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        // function for btn "6"
        private void btn_six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        // function for btn "7"
        private void btn_seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        // function for btn 8
        private void btn_eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        // function for btn "9"
        private void btn_nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        // function for clear - "C"
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        // function for inserting "dot"
        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        // function for math operation "-"
        private void btn_minus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        // function for math oepration "+"
        private void btn_addition_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }
        
        // function for math operation "*"
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "x";
        }

        // function for math operation "/"
        private void btn_divide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "÷";
        }

        // function for final result "="
        private void btn_equals_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double Result;

            secondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (firstNumber + secondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = (firstNumber - secondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }

            if (Operation == "x")
            {
                Result = (firstNumber * secondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }

            if (Operation == "÷")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "Error";
                }
                else
                {
                    Result = (firstNumber / secondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    firstNumber = Result;
                }
        }   }
       
        // function for math operation "sqr root x" 
        private void btn_sqr_root_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            double result = Math.Sqrt(firstNumber);
            textBox1.Text = result.ToString();
        }
        // function for math operation "left bracket"
        private void btn_left_bracket_Click(object sender, EventArgs e)
        {

        }
    }
}
