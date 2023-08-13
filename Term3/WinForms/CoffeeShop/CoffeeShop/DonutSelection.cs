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
    public partial class DonutSelection : UserControl
    {
        public DonutSelection()
        {
            InitializeComponent();
        }

        public string LabelName
        {
            get
            {
                return lblDonut.Text;
            }
            set
            {
                lblDonut.Text = value;
            }
        }

        private void numericUpDownDonut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            if (numericUpDown.Value == 0)
            {
                numericUpDown.Value = 1;
            }
            else if (numericUpDown.Value == 2)
            {
                numericUpDown.Value = 6;
            }
            else if (numericUpDown.Value == 7)
            {
                numericUpDown.Value = 12;
            }
            else if (numericUpDown.Value == 13)
            {
                numericUpDown.Value = 24;
            }
            else if (numericUpDown.Value == 25)
            {
                numericUpDown.Value = 24;
            }
            else if (numericUpDown.Value == 23)
            {
                numericUpDown.Value = 12;
            }
            else if (numericUpDown.Value == 11)
            {
                numericUpDown.Value = 6;
            }
            else if (numericUpDown.Value == 5)
            {
                numericUpDown.Value = 1;
            }
        }

        public override string ToString()
        {
            return this.LabelName + Environment.NewLine + "    Donuts: " + numericUpDownDonut.Value.ToString() + Environment.NewLine;
        }

        private void DonutSelection_Load(object sender, EventArgs e)
        {
            numericUpDownDonut.Value = 1;
        }
    }
}
