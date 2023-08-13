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
    public partial class ColorSelect : UserControl
    {
        public static string PieChartItemColor { get; private set; } = "Random"; //Initial checked value is random

        public ColorSelect()
        {
            InitializeComponent();
        }

        // Set the value of PieChartItemColor based on selected change
        private void rbtnColorRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorRandom.Checked) PieChartItemColor = rbtnColorRandom.Text;
        }

        private void rbtnColorBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorBlack.Checked) PieChartItemColor = rbtnColorBlack.Text;
        }

        private void rbtnColorGray_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorGray.Checked) PieChartItemColor = rbtnColorGray.Text;
        }

        private void rbtnColorCoral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorCoral.Checked) PieChartItemColor = rbtnColorCoral.Text;
        }

        private void rbtnColorRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorRed.Checked) PieChartItemColor = rbtnColorRed.Text;
        }

        private void rbtnColorMaroon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorMaroon.Checked) PieChartItemColor = rbtnColorMaroon.Text;
        }

        private void rbtnColorOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorOrange.Checked) PieChartItemColor = rbtnColorOrange.Text;
        }

        private void rbtnColorYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorYellow.Checked) PieChartItemColor = rbtnColorYellow.Text;
        }

        private void rbtnColorGold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorGold.Checked) PieChartItemColor = rbtnColorGold.Text;
        }

        private void rbtnColorOlive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorOlive.Checked) PieChartItemColor = rbtnColorOlive.Text;
        }

        private void rbtnColorLime_CheckedChanged(object sender, EventArgs e)
        {
             if (rbtnColorLime.Checked) PieChartItemColor = rbtnColorLime.Text;
        }

        private void rbtnColorGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnColorGreen.Checked) PieChartItemColor = rbtnColorGreen.Text;
        }

        private void rbtnColorCyan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorCyan.Checked) PieChartItemColor = rbtnColorCyan.Text;
        }

        private void rbtnColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorBlue.Checked) PieChartItemColor = rbtnColorBlue.Text;
        }

        private void rbtnColorNavy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorNavy.Checked) PieChartItemColor = rbtnColorNavy.Text;
        }

        private void rbtnColorPink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorPink.Checked) PieChartItemColor = rbtnColorPink.Text;
        }

        private void rbtnColorFuchsia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorFuchsia.Checked) PieChartItemColor = rbtnColorFuchsia.Text;
        }

        private void rbtnColorPurple_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnColorPurple.Checked) PieChartItemColor = rbtnColorPurple.Text;
        }
    }
}
