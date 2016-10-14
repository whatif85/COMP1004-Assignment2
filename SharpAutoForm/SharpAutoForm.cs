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
            ClearAll();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
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
            CalculateTotal();
        }
        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        { 
            double Price = 0.0;
            double Total;
            double SalesTax;
            double TradeInAmount = 10.0;
            double AmountDue;


            // Add the price of selected accessories and exterior finish to the base price and display the result the Subtotal Text Box.
            if (StereoSystemCheckBox.Checked)
            {
                Price += 425.76;
                SubTotalTextBox.Text = Price.ToString("C2");
            }

            if (LeatherInteriorCheckBox.Checked)
            {
                Price += 987.41;
                SubTotalTextBox.Text = Price.ToString("C2");
            }

            if (ComputerNavigationCheckBox.Checked)
            {
                Price += 1741.23;
                SubTotalTextBox.Text = Price.ToString("C2");
            }

            if (StandardFinishRadioButton.Checked)
            {
                Price += 0.00;
                SubTotalTextBox.Text = Price.ToString("C2");
            }

            if (PearlizedFinishRadioButton.Checked)
            {
                Price += 345.72;
                SubTotalTextBox.Text = Price.ToString("C2");
            }

            if (CustomizedDetailingRadioButton.Checked)
            {
                Price += 599.99;
                SubTotalTextBox.Text = Price.ToString("C2");
            }

            /*
            * ii. Write a function procedure to calculate and return the Sales Tax (13%) on the SubTotal
            * and display the result in the Total Text Field
            */

            SalesTax = Price * 0.13;
            SalesTaxTextBox.Text = SalesTax.ToString("C2");
            Total = SalesTax + Price;
            TotalTextBox.Text = Total.ToString("C2");

            Total -= TradeInAmount;
            TradeInAllowanceTextBox.Text = TradeInAmount.ToString("C2");

            /*
            * iii. Subtract any Trade-in amount from the total and display the result of the calculations
            * in the Amount Due Text Field
            */
            AmountDue = TradeInAmount - (SalesTax + Price);
            AmountDueTextBox.Text = AmountDue.ToString("C2");
        }

        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BaseCost();
        }

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BaseCost();
        }

        private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BaseCost();
        }

        private void StandardFinishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BaseCost();
        }

        private void PearlizedFinishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BaseCost();
        }

        private void CustomizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BaseCost();
        }

        private void BaseCost()
        {
            double AccessoryCost = 0.0;

            if (StereoSystemCheckBox.Checked)
            {
                AccessoryCost += 425.76;
                BasePriceTextBox.Text = AccessoryCost.ToString("C2");
            }

            if (LeatherInteriorCheckBox.Checked)
            {
                AccessoryCost += 987.41;
                BasePriceTextBox.Text = AccessoryCost.ToString("C2");
            }

            if (ComputerNavigationCheckBox.Checked)
            {
                AccessoryCost += 1741.23;
                BasePriceTextBox.Text = AccessoryCost.ToString("C2");
            }

            if (StandardFinishRadioButton.Checked)
            {
                AccessoryCost += 0.0;
                BasePriceTextBox.Text = AccessoryCost.ToString("C2");
            }

            if (PearlizedFinishRadioButton.Checked)
            {
                AccessoryCost += 345.72;
                BasePriceTextBox.Text = AccessoryCost.ToString("C2");
            }

            if (CustomizedDetailingRadioButton.Checked)
            {
                AccessoryCost += 599.99;
                BasePriceTextBox.Text = AccessoryCost.ToString("C2");
            }
        }
    }
}
