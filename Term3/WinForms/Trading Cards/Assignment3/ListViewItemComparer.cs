using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    // Comparer class to sort based on column and either ascending or descending
    internal class ListViewItemComparer : IComparer
    {
        private int col;
        private string orderBy;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column, string orderBy)
        {
            col = column;
            this.orderBy = orderBy;
        }
        public int Compare(object x, object y)
        {
            // If we are working with numbers
            if (col == 0)
            {
                if (orderBy == "Descending")
                    return int.Parse(((ListViewItem)y).SubItems[col].Text).CompareTo(int.Parse(((ListViewItem)x).SubItems[col].Text));
                else
                    return int.Parse(((ListViewItem)x).SubItems[col].Text).CompareTo(int.Parse(((ListViewItem)y).SubItems[col].Text));
            }
            // If we are working with strings
            else
            {
                if (orderBy == "Descending")
                    return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
                else
                    return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}
