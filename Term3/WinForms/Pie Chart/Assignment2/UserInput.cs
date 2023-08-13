using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class UserInput : UserControl
    {
        public UserInput()
        {
            InitializeComponent();
        }

        // Filtering the value input
        private void txtBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow control keys, digits, decimal point and negative
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        // Add the item/piece to the list
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Random r = new Random(); // For random generation
            if (txtBoxName.Text == "" || txtBoxValue.Text == "") // If user forgot to enter data
            {
                EnterInfo enterInfo = new EnterInfo();
                enterInfo.ShowDialog(); // Remind them
                return; // Stop the function
            }

            var parent = this.Parent as MainForm; // Get values from the main form

            if (ColorSelect.PieChartItemColor == "Random") // If selected value is random
            {
                var colorChoices = parent.ColorChoices; // Set up our options
                Color color = colorChoices[r.Next(colorChoices.Count)]; // Pick something at random
                while(parent.PieChartItems.Any(i => i.Color == color)) // In case the option is already in use
                    color = colorChoices[r.Next(colorChoices.Count)]; // Pick something else

                parent.AddItem(txtBoxName.Text, float.Parse(txtBoxValue.Text), color); // When we have our unique color add the item
            }
            else
            {
                Color color = Color.FromName(ColorSelect.PieChartItemColor); // Get the selected color
                if (parent.PieChartItems.Any(i => i.Color == color)) // Check if it is already in use
                {
                    ColorInUse colorInUse = new ColorInUse();
                    colorInUse.ShowDialog(); // Notify the user
                    return; // Stop the function
                }
                parent.AddItem(txtBoxName.Text, float.Parse(txtBoxValue.Text), color); // When we have our unique color add the item
            }

            // Reset text box values
            txtBoxName.Text = "";
            txtBoxValue.Text = "";
        }
    }
}
