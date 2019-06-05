using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Employee> employees = DataRepository.Employee.GetAllOrderByLastName();

            uscCustomerSearch.SetEmployeeDataSource(employees);
        }

        private void UscCustomerSearch_SearchButtonClicked(object sender, Controls.CustomerSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Customer> customers = DataRepository.Customer.Search(e.LastName, e.EmployeeId);

            uscCustomerList.SetCustomerDataSource(customers);
        }
    }
    
}
