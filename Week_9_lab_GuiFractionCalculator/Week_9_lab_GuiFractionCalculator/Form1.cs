using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9_lab_GuiFractionCalculator
{
    public partial class Form1 : Form
    {
        //Declare instance variables
        private Fraction fraction1;
        private Fraction fraction2;
        private string operation;

        public Form1()
        {
            InitializeComponent();

            //Subscribe all text boxes to the KeyPress event handler
            textFrac1Numerator.KeyPress += TextBox_KeyPress;
            textFrac1Denominator.KeyPress += TextBox_KeyPress;
            textFrac2Numerator.KeyPress += TextBox_KeyPress;
            textFrac2Denominator.KeyPress += TextBox_KeyPress;

            //Subscribing event handler to clear button event
            btnClear.Click += btnClear_Click;
        }

        // Event handler for KeyPress event of all text boxes
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;          //discard the non-digit entries

        }

        //Method to perform calculation
        private void DoCalculation()
        {
            if (fraction1 == null || fraction2 == null)  // Check if fractions are initialized. If null, return. 
                return;

            // Check if any denominator is zero
            if (fraction1.Bottom == 0 || fraction2.Bottom == 0)
            {
                MessageBox.Show("Please retry. Denominator cannot be 0."); //display error if any denominator is set to 0.
                return;
            }
            Fraction result = null;

            //Perform calculation based on selected operation on GUI
            switch (operation)
            {
                case "+":
                    result = fraction1 + fraction2;
                    break;
                case "-":
                    result = fraction1 - fraction2;
                    break;
                case "*":
                    result = fraction1 * fraction2;
                    break;
                case "/":
                    if (fraction2.Top == 0)
                    {
                        MessageBox.Show("Please retry. Cannot divide by zero."); //display error if fraction 2 is 0.
                        return;
                    }
                    result = fraction1 / fraction2;
                    break;
            }

            //Display result in textbox if result is not null
            if (result != null)
            {
                txtResultNumerator.Text = result.Top.ToString();
                txtResultDenominator.Text = result.Bottom.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Event handlers for the radio buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked) //perform addition operation when addition radio button is selected
            {
                operation = "+";
                DoCalculation();
            }
        }
        private void radioBtnSubtract_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSubtract.Checked) //perform subtraction operation when addition radio button is selected
            {
                operation = "-";
                DoCalculation();
            }
        }

        private void radioBtnMultiply_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnMultiply.Checked) //perform multiplication operation when addition radio button is selected
            {
                operation = "*";
                DoCalculation();
            }
        }

        private void radioBtnDivide_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnDivide.Checked) //perform division operation when addition radio button is selected
            {
                operation = "/";
                DoCalculation();
            }
        }

        //Event handler for Perform Operation button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse user input and create Fraction objects. Convert int to string
            if (!int.TryParse(textFrac1Numerator.Text, out int numerator1) ||
                !int.TryParse(textFrac1Denominator.Text, out int denominator1) ||
                !int.TryParse(textFrac2Numerator.Text, out int numerator2) ||
                !int.TryParse(textFrac2Denominator.Text, out int denominator2))
            {
                MessageBox.Show("Missing input. Please enter valid integers as numerators or denominators."); //display error if input is invalid (e.g, no value for numerator or denominator)
                return;
            }
            fraction1 = new Fraction(numerator1, denominator1);
            fraction2 = new Fraction(numerator2, denominator2);
            DoCalculation();
        }

        //Event handler for Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            textFrac1Numerator.Clear();
            textFrac1Denominator.Clear();
            textFrac2Numerator.Clear();
            textFrac2Denominator.Clear();
            txtResultNumerator.Clear();
            txtResultDenominator.Clear();

            // Reset Fraction objects and operation
            fraction1 = null;
            fraction2 = null;
            operation = null;

            // Uncheck radio buttons
            radioBtnAdd.Checked = false;
            radioBtnSubtract.Checked = false;
            radioBtnMultiply.Checked = false;
            radioBtnDivide.Checked = false;

            // Reset TabStop property of radio buttons
            radioBtnAdd.TabStop = true;
            radioBtnSubtract.TabStop = true;
            radioBtnMultiply.TabStop = true;
            radioBtnDivide.TabStop = true;
        }

        private void txtResultNumerator_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtResultDenominator_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFrac1Numerator_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFrac1Denominator_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFrac2Numerator_TextChanged(object sender, EventArgs e)
        {

        }
        private void textFrac2Denominator_TextChanged(object sender, EventArgs e)
        {

        }

        //event handler for simplify result button
        private void button1_Click(object sender, EventArgs e)
        {
            if (fraction1 == null || fraction2 == null) // Check if fractions are initialized. If null, return.
                return;

            // Try parsing numerator and denominator from text boxes
            int numerator, denominator;
            if (!int.TryParse(txtResultNumerator.Text, out numerator) || !int.TryParse(txtResultDenominator.Text, out denominator))
            {
                //Display error message if parsing fails
                MessageBox.Show("Please enter valid values for the numerator or denominator fields.");
                return;
            }
            //Create a Fraction object with the parsed numerator and denominator
            Fraction result = new Fraction(numerator, denominator);

            //simplify fraction
            Fraction simplifiedResult = result.Simplify();

            // Display simplified result in textbox
            txtResultNumerator.Text = simplifiedResult.Top.ToString();
            txtResultDenominator.Text = simplifiedResult.Bottom.ToString();
        }
    }
}
