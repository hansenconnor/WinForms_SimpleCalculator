using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // Define struct to hold value from form fields
        public enum Units { Metric, Imperial };
        public struct CalculatorFormData
        {
            public int mass1;
            public int mass2;
            public int distance;
            public string email;
            public Units units;
        };

        // Displays help form
        private void button2_Click(object sender, EventArgs e)
        {
            // Display Help Form dialog
            var helpForm = new HelpForm();
            helpForm.Show();
        }


        // Resets fields and inputs to default values
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset all controls
            Utilities.ResetAllControls(this);
        }


        // Calculate and display solution form
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Get form values
            // ... Create struct on stack.
            CalculatorFormData data = new CalculatorFormData();
            
            // Get the checked radio button
            foreach (var control in unitsRadioGroup.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked && radio.Name == "radioKilogramsMeters")
                {
                    data.units = Units.Metric;
                }
                else if (radio != null && radio.Checked && radio.Name == "radioPoundsFeet")
                {
                    data.units = Units.Imperial;
                } else
                {
                    // default
                    data.units = Units.Metric;
                }
            }

            // Validate email field
            if (!IsValidEmail(emailField.Text))
            {
                // Display input validation error in message box and inline
                MessageBox.Show("Please enter a valid email address...", "Error");
                emailErrorLabel.Show();
                emailLabel.Hide();
                return;
            } else
            {
                // Set defaults for email labels
                emailErrorLabel.Hide();
                emailLabel.Show();
                data.email = emailField.Text;
            }

            // Input is validated by the control itself for the following
            data.mass1      = Convert.ToInt32(mass1.Value);
            data.mass2      = Convert.ToInt32(mass2.Value);
            data.distance   = Convert.ToInt32(distance.Value);

            // Send data struct to solution form
            displaySolutionForm(data);
        }



        // Function for email validation
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }



        public void displaySolutionForm(CalculatorFormData data)
        {
            // Create new SolutionForm instance and pass the form data
            Form solutionForm = new SolutionForm(data);
            solutionForm.Show();
        }



        // Dynamically updated units labels on radio button click
        private void radioKilogramsMeters_CheckedChanged(object sender, EventArgs e)
        {
            // Set units to Metric
            mass1Units.Text     = "Kg";
            mass2Units.Text     = "Kg";
            distanceUnits.Text  = "m";
        }

        // Dynamically updated units labels on radio button click
        private void radioPoundsFeet_CheckedChanged(object sender, EventArgs e)
        {
            // Set units to Imperial
            mass1Units.Text = "lbs";
            mass2Units.Text = "lbs";
            distanceUnits.Text = "ft";
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            emailField.SelectAll();
        }
    }
}
