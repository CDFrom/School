using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeSelection : UserControl
    {
        public CoffeeSelection()
        {
            InitializeComponent();
        }

        private void CoffeeSelection_Load(object sender, EventArgs e)
        {

        }

        public string LabelName
        {
            get
            {
                return lblCoffee.Text;
            }
            set
            {
                lblCoffee.Text = value;
            }
        }

        public override string ToString()
        {
            string message = this.LabelName + Environment.NewLine;
            if (rbtnSmall.Checked)
            {
                message += "    Size: Small " + Environment.NewLine;
            }
            else if (rbtnMedium.Checked)
            {
                message += "    Size: Medium " + Environment.NewLine;
            }
            else
            {
                message += "    Size: Large " + Environment.NewLine;
            }
            message += "        Cream: " + numericUpDownCream.Value.ToString() + Environment.NewLine;
            message += "        Sugar: " + numericUpDownSugar.Value.ToString() + Environment.NewLine;
            message += "        Whipped Cream: " + (checkBoxWhippedCream.Checked ? "Yes" : "No") + Environment.NewLine;

            return message;
        }

        private void rbtnSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnLarge_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
