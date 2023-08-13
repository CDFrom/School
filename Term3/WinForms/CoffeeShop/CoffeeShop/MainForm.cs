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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(Image.FromFile("cappuccino-g28feef019_1920.jpg"));
            pBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxLogo.Image = picture;
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            containerShop.AddCoffee();
        }

        private void btnDonut_Click(object sender, EventArgs e)
        {
            containerShop.AddDonut();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            containerShop.Clear();
            txtOrder.Text = string.Empty;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            txtOrder.Text = containerShop.ToString();
        }
    }
}
