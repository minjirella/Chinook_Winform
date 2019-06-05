using System.Windows.Forms;

namespace Chinook.Utilities
{
    public static class ControlExtension
    {
        public static void ToUneditableMode(this DataGridView grid)
        {
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
