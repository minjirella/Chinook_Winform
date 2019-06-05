using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;

namespace Chinook.Controls
{
    public partial class InvoiceListControl : ListControl
    {
        public InvoiceListControl()
        {
            InitializeComponent();
        }

        public void SetInvoiceDataSource(List<Invoice> invoices)
        {
            bdsInvoice.DataSource = invoices;
        }
    }
}
