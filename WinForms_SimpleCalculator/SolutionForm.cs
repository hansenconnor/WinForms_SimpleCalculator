using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinForms_SimpleCalculator.CalculatorForm;

namespace WinForms_SimpleCalculator
{
    public partial class SolutionForm : Form
    {
        public SolutionForm(CalculatorFormData data)
        {
            InitializeComponent();

            // Calculate result
            double result = Utilities.calculateGravitationalForce(data);

            // Update result label to display the result
            ResultLabel.Text = result.ToString() + "Newtons";
        }
    }
}
