using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class CustomerData : EntityData<Customer>
    {
        public Customer GetByPK(int customerId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
            }
        }

        public void DeleteByPK(int customerId)
        {
            Customer entity = GetByPK(customerId);

            if (entity == null)
                return;

            Delete(entity);
        }
        //public List<Customer> Search(string customerName, int? customerId)
        //{
        //    using (ChinookEntities context = new ChinookEntities())
        //    {
        //        Dictionary<int, string> employeeNames = context.Employees.ToDictionary(x => x.EmployeeId, x => x.LastName);

        //        IQueryable<Customer> query = from x in context.Customers
        //                                  select x;

        //        // lazy execution

        //        if (string.IsNullOrEmpty(customerName) == false)
        //            query = query.Where(x => x.LastName.Contains(customerName));

        //        //if (artistId != null)
        //        if (customerId.HasValue)
        //            query = query.Where(x => x.CustomerId == customerId);

        //        var customers = query.ToList();

        //        //foreach (var album in albums)
        //        //    //album.ArtistName = artists.Find(x => x.ArtistId == album.ArtistId).Name;
        //        //    album.ArtistName = artistNames[album.ArtistId];

        //        foreach (var customer in customers)
        //            //customer.EmployeeName = employeeNames[customer.SupportRepId];
        //        //customer.EmployeeName = customers.Find(x => x.SupportRepId == customer.Employee.EmployeeId).LastName;

        //        return customers;
        //    }
        //}

        public List<Customer> Search(string customerName, int? employeeId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Customers
                            select new
                            {
                                EmployeeName = x.Employee.LastName,
                                Customer = x
                            };

                if (string.IsNullOrEmpty(customerName) == false)
                    query = query.Where(x => x.Customer.LastName.Contains(customerName));
                if (employeeId != null)
                    query = query.Where(x => x.Customer.SupportRepId == employeeId.Value);

                var list = query.ToList();

                foreach (var x in list)
                    x.Customer.EmployeeName = x.EmployeeName;

                return list.ConvertAll(x => x.Customer);
            }
        }
    }
}
