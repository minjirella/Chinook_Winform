using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class InvoiceListForm : Form
    {
        private InvoiceListForm()
        {
            InitializeComponent();
        }

        // 코드리뷰 반영
        // public int _customerId { get; internal set; }
        // 위와 같이 자동 프로퍼티로 사용하는 경우는 피해야한다.
        // 아래와 같이, private로 내부 필드를 정의하고, 생성자를 호출해서 필드 값을 받아오는 방식이 가장 현명하고, 안전하다.

        public InvoiceListForm(Customer customer) : this() // <-- 이런 모양의 생성자 호출
        {
            _customer = customer;
        }

        private Customer _customer;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Invoice> invoices = DataRepository.Invoice.GetByCustomerId(_customer.CustomerId);

            lblCustomerName.Text = invoices[0].CustomerName;
            uscInvoice.SetInvoiceDataSource(invoices);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
