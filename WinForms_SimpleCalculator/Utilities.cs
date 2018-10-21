using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinForms_SimpleCalculator.CalculatorForm;

namespace WinForms_SimpleCalculator
{
    public class Utilities
    {
        // Reset all form controls
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = textBox.Tag.ToString();
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = numericUpDown.Minimum;
                }
            }
        }


        // Calculate Gravitational Force
        public static double calculateGravitationalForce(CalculatorFormData data)
        {
            double F = 0;
            
            // Gravitational Constant
            const double G = 6.6720e-11;

            // Calculate mass product
            int massProd = data.mass1 * data.mass2;

            // Distance squared
            int distSquared = data.distance ^ 2;

            // Calculate force
            F = G * (massProd / distSquared);
             
            return F;
        }
    }
}
