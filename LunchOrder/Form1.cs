/*
 * Title: Lunch Order Application
 * Author: Steele Shreve
 * Date: 08.31.22
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Event handler to close application
            this.Close();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Event handler to place an order

            // Variables
            double subtotal = 0;
            double tax;
            double orderTotal;
            int addons = 0;

            // Calculate total when user orders hamburger, and or sides
            if (radHamburger.Checked)
            {
                if (checkBox1.Checked)
                {
                    addons += 1;
                }
                if (checkBox2.Checked)
                {
                    addons += 1;
                }
                if (checkBox3.Checked)
                {
                    addons += 1;
                }
                subtotal = 6.95 + (.75 * addons);
            }

            // Calculate total when user orders pizza, and or sides
            if (radPizza.Checked)
            {
                if (checkBox1.Checked)
                {
                    addons += 1;
                }
                if (checkBox2.Checked)
                {
                    addons += 1;
                }
                if (checkBox3.Checked)
                {
                    addons += 1;
                }
                subtotal = 5.95 + (.50 * addons);
            }

            // Calculate total when user orders salad, and or sides
            if (radSalad.Checked)
            {
                if (checkBox1.Checked)
                {
                    addons += 1;
                }
                if (checkBox2.Checked)
                {
                    addons += 1;
                }
                if (checkBox3.Checked)
                {
                    addons += 1;
                }
                subtotal = 4.95 + (.25 * addons);
            }
            // Display results
            txtSubtotal.Text = subtotal.ToString("C");
            tax = subtotal * 0.0775;
            txtSalesTax.Text = tax.ToString("C");
            orderTotal = subtotal + tax;
            txtOrderTotal.Text = orderTotal.ToString("C");
        }
        private void ClearTotals()
        {
            // Clear totals method
            txtSubtotal.Clear();
            txtSalesTax.Clear();
            txtOrderTotal.Clear();
        }
        private void ClearAddOns()
        {
            // Clear add-ons method
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            // Clear add-ons & totals when user selects a different main course
            ClearAddOns();
            ClearTotals();
            gbxAddOnItems.Text = "Add-on items ($.75/each)";
            checkBox1.Text = "Lettuce, tomato, and onions";
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox3.Text = "French fries";
        }
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            // Clear add-ons & totals when user selects a different main course
            ClearAddOns();
            ClearTotals();
            gbxAddOnItems.Text = "Add-on items ($.50/each)";
            checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";
        }
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            // Clear add-ons & totals when user selects a different main course
            ClearAddOns();
            ClearTotals();
            gbxAddOnItems.Text = "Add-on items ($.25/each)";
            checkBox1.Text = "Croutons";
            checkBox2.Text = "Bacon bits";
            checkBox3.Text = "Bread sticks";
        }
        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            // Clear totals when user checks/unchecks an addon
            ClearTotals();
        }
    }
}