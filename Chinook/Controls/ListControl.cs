using Chinook.Utilities;
using System;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class ListControl : UserControl
    {
        public ListControl()
        {
            InitializeComponent();
        }

        protected virtual DataGridView DataGridView
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode && Program.IsRunning == false)
                return;

            DataGridView.ToUneditableMode();
            DataGridView.DoubleClick += DataGridView_DoubleClick;
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            object entity = DataGridView.CurrentRow.DataBoundItem;

            if (entity == null)
                return;

            OnEntityDoubleClick(entity);
        }

        protected virtual void OnEntityDoubleClick(object entity)
        {
        }
    }
}
