using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This program calculates the amount due on a New or Used Vehicle.", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            AdditionalOptionsTextBox.Text = String.Empty;
            SubTotalTextBox.Text = String.Empty;
            SalesTaxTextBox.Text = String.Empty;
            TotalTextBox.Text = String.Empty;
            AmountDueTextBox.Text = String.Empty;

            // clear all checkboxes
            StereoSystemCheckBox.Checked = false;
            LeatherInteriorCheckBox.Checked = false;
            ComputerNavigationCheckBox.Checked = false;

            // set radio buttons to default settings
            StandardFinishRadioButton.Checked = true;
            PearlizedFinishRadioButton.Checked = false;
            CustomizedDetailingRadioButton.Checked = false;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            /*
            TotalMonthlySales = Convert.ToDouble(TotalMonthlySalesTextBox.Text);
                    // TotalBonusAmount = Convert.ToDouble(SalesBonusTextBox);

                    // 1. Determine the Percentage of hours worked during the bonus period
                    // Divide the Total Hours  Worked by 160
                    PercentageHoursWorked = HoursWorked / 160;

                    // 2. Calculate 2% of Sales which is the Total Bonus Amount.
                    // Multiply Total Monthly Sales by 0.02
                    BonusAmount = TotalMonthlySales * 0.02;

                    // 3. Determine the value you need to display in the Sales Bonus Text Field
                    // Multiply the Percentage of Hours Worked by the Total Bonus Amount
                    SalesBonus = PercentageHoursWorked * BonusAmount;

                    // Display DiscountAmount in related Text Box
                    TotalMonthlySalesTextBox.Text = TotalMonthlySales.ToString("C2"); // $ in two decimal places
                    // Display Bonus in related Text Box
                    SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            */

            /*
            i. Add the price of selected accessories and exterior finish to the base price and display
                the result the Subtotal Text Box.
            ii. Write a function procedure to calculate and return the Sales Tax (13%) on the SubTotal
                and display the result in the Total Text Field.
            iii. Subtract any Trade-in amount from the total and display the result of the calculations in
            the Amount Due Text Field.

            Stereo System           $425.76
            Leather Interior        $987.41
            Computer Navigation     $1,741.23
            Standard                No Additional Charge
            Pearlized               $345.72
            Customized Detailing    $599.99
            Tax Rate                13.0%

            double AccessoryStereoSystemCost;
            double AccessoryLeatherInteriorCost;
            double AccessoryComputerNavigationCost;

            double PearlizedFinish;
            double CustomDetailing;
            
            double TaxRate = 0.13;

            */
        }
    }
}
