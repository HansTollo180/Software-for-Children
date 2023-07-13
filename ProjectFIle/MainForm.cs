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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        //Simple Button that open other forms
        //Browser Form
        //Calculator Form
        //Text Editor
        private void Browser_Button_Click(object sender, EventArgs e)
        {
            var Browser = new BrowserForm();
            Browser.Show();

        }

        private void TextEditor_Button_Click(object sender, EventArgs e)
        {
            var TextEditor = new TextEditorForm();
            TextEditor.Show();
        }

        private void Calculator_Button_Click(object sender, EventArgs e)
        {
            var Calculator = new CalculatorForm();
            Calculator.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}