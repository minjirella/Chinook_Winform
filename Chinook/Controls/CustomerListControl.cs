using Chinook.Data;
using Chinook.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class CustomerListControl : ListControl
    {
        public CustomerListControl()
        {
            InitializeComponent();
        }

        protected override DataGridView DataGridView
        {
            get
            {
                return dgvCustomer;
            }
        }

        public void SetCustomerDataSource(List<Customer> customers)
        {
            bdsCustomer.DataSource = customers;
        }

        private void DgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = dgvCustomer.CurrentRow.DataBoundItem as Customer;//캐스팅 실패시 null 반환

            InvoiceListForm invoiceListForm = new InvoiceListForm(customer);
            invoiceListForm.ShowDialog();
        }
    }
}
