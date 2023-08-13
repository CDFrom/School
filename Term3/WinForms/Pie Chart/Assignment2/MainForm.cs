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
    public partial class MainForm : Form
    {
        private List<PieChartItem> _pieChartItems = new List<PieChartItem>(); // Store our pieces/items
        public List<PieChartItem> PieChartItems { get { return _pieChartItems; } } // Retrieve them

        // Our list of colors
        public List<Color> ColorChoices = new List<Color>() { Color.Black, Color.Gray,
                                                              Color.Coral, Color.Red, Color.Maroon,
                                                              Color.Orange, Color.Yellow, Color.Gold,
                                                              Color.Olive, Color.Lime, Color.Green,
                                                              Color.Cyan, Color.Blue, Color.Navy,
                                                              Color.Pink, Color.Fuchsia, Color.Purple};

        public MainForm()
        {
            InitializeComponent();
        }

        // Adding items to the list
        public void AddItem(string name, float value, Color color)
        {
            if (PieChartItems.Count == 15) // Do not allow more than 15 items
            {
                CountMax countMax = new CountMax();
                countMax.ShowDialog(); // Remind user
                return; // Stop function
            }

            PieChartItem pieChartItem = new PieChartItem(name, value, color); // Create a new object based on given parameters
            _pieChartItems.Add(pieChartItem); // Add it to the list
            legend.EditLegend(PieChartItems); // Update the legend
            pieChart.UpdatePieChart(); // Update the pie chart drawing
        }

        // Delete the last item in the list
        public void DeleteLastItem()
        {
            if (PieChartItems.Count > 0) // Make sure we don't have an empty list
            {
                _pieChartItems.RemoveAt(PieChartItems.Count - 1); // Delete the item at the last index
                pieChart.UpdatePieChart(); // Update the pie chart drawing
                legend.EditLegend(PieChartItems); // Update the legend
            }
        }

        // Clear all items in the list
        public void ClearItems()
        {
            _pieChartItems.Clear(); // Clear all the items
            pieChart.UpdatePieChart(); // Update the pie chart drawing
            legend.EditLegend(PieChartItems); // Update the legend
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
