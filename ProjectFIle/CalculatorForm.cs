using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFIle
{
    public partial class CalculatorForm : Form
    {
        //Variables
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //Number buttons
        private void button_Click(object sender, EventArgs e)
        {
            //IF statement  --- This keep the 0 clear and also the operator
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            //this will append any of the button to the text box
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        //Operator buttons
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + "" + operation;

            

        }

        //Equal button 
        //Switch statetement 
        private void button16_Click(object sender, EventArgs e)
        {
           
            equation.Text = "";
            switch (operation)
            {
                case "+":
                   result.Text = (value + Double.Parse(result.Text)).ToString();
                   break;
                case "-":
                   result.Text = (value - Double.Parse(result.Text)).ToString();
                   break;
                case "X":
                   result.Text = (value * Double.Parse(result.Text)).ToString();
                   break;
                case "/":
                   result.Text = (value / Double.Parse(result.Text)).ToString();
                   break;
                default:
                   break;
            }
            
        }

        //CE button, clear screen to 0
        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        //C button to clear
        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }


    }
}
