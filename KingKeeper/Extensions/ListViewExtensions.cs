using System;
using System.Windows.Forms;

namespace KingKeeper.Extensions
{
    public static class ListViewExtensions
    {
        public static int FirstSelectedIndex(this ListView list)
        {
            if (list.SelectedIndices.Count > 0)
            {
                return list.SelectedIndices[0];
            }

            return -1;
        }

        public static ListViewItem FirstSelectedItem(this ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                return list.SelectedItems[0];
            }

            return null;
        }
    }
}
