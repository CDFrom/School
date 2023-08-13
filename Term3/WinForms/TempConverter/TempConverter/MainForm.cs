using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Number_Temperature(object sender, EventArgs e)
        {
            Button TemperatureButton = (Button)sender;

            if (lblTemp.Text == "0")
            {
                lblTemp.Text = "";
            }

            if (TemperatureButton.Text == ".")
            {
                if(!lblTemp.Text.Contains("."))
                {
                    lblTemp.Text += TemperatureButton.Text;
                }
            }
            else
            {
                lblTemp.Text += TemperatureButton.Text;
            }

            calculateTemp();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblTemp.Text.Length > 0)
            {
                lblTemp.Text = lblTemp.Text.Remove(lblTemp.Text.Length - 1, 1);
            }

            if (lblTemp.Text == "")
            {
                lblTemp.Text = "0";
            }

            calculateTemp();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTemp.Text = "0";

            calculateTemp();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (cmbTemp.Text == "K")
            {
                return;
            }
            if (lblTemp.Text.Contains("-"))
            {
                lblTemp.Text = lblTemp.Text.Remove(0, 1);
            }
            else
            {
                lblTemp.Text = "-" + lblTemp.Text;
            }

            calculateTemp();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbTemp.Text = "F";

            cmbTemp.Items.Add("C");
            cmbTemp.Items.Add("F");
            cmbTemp.Items.Add("K");

            cmbConverter.Text = "C";

            cmbConverter.Items.Add("C");
            cmbConverter.Items.Add("F");
            cmbConverter.Items.Add("K");

            calculateTemp();
        }

        private void calculateTemp()
        {
            if (lblTemp.Text == ".")
            {
                return;
            }

            Double value;
            value = Double.Parse(lblTemp.Text);

            lblConverter.Text = Converter(value, cmbTemp.Text, cmbConverter.Text);

            if (cmbTemp.Text == cmbConverter.Text)
            {
                lblOther.Text = cmbTemp.Text == "C"
                    ? String.Format("{0} and {1}", Converter(value, cmbTemp.Text, "F"), Converter(value, cmbTemp.Text, "K"))
                    : cmbTemp.Text == "F"
                    ? String.Format("{0} and {1}", Converter(value, cmbTemp.Text, "C"), Converter(value, cmbTemp.Text, "K"))
                    : String.Format("{0} and {1}", Converter(value, cmbTemp.Text, "F"), Converter(value, cmbTemp.Text, "C"));
            }
            else if (cmbTemp.Text == "C")
            {
                lblOther.Text = cmbConverter.Text == "F"
                    ? String.Format("{0}", Converter(value, cmbTemp.Text, "K"))
                    : String.Format("{0}", Converter(value, cmbTemp.Text, "F"));
            }
            else if (cmbTemp.Text == "F")
            {
                lblOther.Text = cmbConverter.Text == "C"
                    ? String.Format("{0}", Converter(value, cmbTemp.Text, "K"))
                    : String.Format("{0}", Converter(value, cmbTemp.Text, "C"));
            }
            else
            {
                lblOther.Text = cmbConverter.Text == "C"
                    ? String.Format("{0}", Converter(value, cmbTemp.Text, "F"))
                    : String.Format("{0}", Converter(value, cmbTemp.Text, "C"));
            }
        }

        private String Converter(Double value, String fromTemp, String toTemp)
        {
            try
            {
                switch (fromTemp)
                {
                    case "C":
                        switch (toTemp)
                        {
                            case "F":
                                return String.Format("{0}\u00B0F", Math.Round(value * 9 / 5 + 32, 2).ToString());
                            case "K":
                                return String.Format("{0}K", Math.Round(value + 273.15, 2).ToString());
                            case "C":
                                return String.Format("{0}\u00B0C", Math.Round(value, 2).ToString());
                        }
                        break;

                    case "F":
                        switch (toTemp)
                        {
                            case "F":
                                return String.Format("{0}\u00B0F", Math.Round(value, 2).ToString());
                            case "K":
                                return String.Format("{0}K", Math.Round((value - 32) * (5.0 / 9.0) + 273.15, 2).ToString());
                            case "C":
                                return String.Format("{0}\u00B0C", Math.Round((value - 32) * (5.0 / 9.0), 2).ToString());
                        }
                        break;

                    case "K":
                        switch (toTemp)
                        {
                            case "F":
                                return String.Format("{0}\u00B0F", Math.Round((value - 273.15) * 9 / 5 + 32, 2).ToString());
                            case "K":
                                return String.Format("{0}K", Math.Round(value, 2).ToString());
                            case "C":
                                return String.Format("{0}\u00B0C", Math.Round(value - 273.15, 2).ToString());
                        }
                        break;
                }
                throw new ArgumentException("Invalid Conversion");
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }

        private void cmbTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemp.Text == "K" && lblTemp.Text.Contains("-"))
            {
                lblTemp.Text = lblTemp.Text.Remove(0, 1);
            }

            calculateTemp();
        }
    }
}
