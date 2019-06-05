using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class CustomerSearchControl : UserControl
    {
        public CustomerSearchControl()
        {
            InitializeComponent();
        }

        internal void SetEmployeeDataSource(List<Employee> employees)
        {
            uscEmployee.SetDataSource(employees, nameof(Employee.LastName), nameof(Employee.EmployeeId));
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string lastName, int? employeeId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(lastName, employeeId);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string LastName { get; set; }
            public int? EmployeeId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string lastName, int? employeeId)
            {
                LastName = lastName;
                EmployeeId = employeeId;
            }
        }

        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked(txtLastName.Text, uscEmployee.SelectedValue);
        }
    }
}
