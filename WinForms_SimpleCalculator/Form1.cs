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


            // 
        }
    }
}
