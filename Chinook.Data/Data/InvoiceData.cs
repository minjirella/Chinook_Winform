using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class InvoiceData : EntityData<Invoice>
    {
        public List<Invoice> GetByCustomerId(int customerId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Invoices
                            select new
                            {
                                CustomerName = x.Customer.LastName,
                                Invoice = x
                            };

                query = query.Where(x => x.Invoice.CustomerId == customerId);

                var list = query.ToList();

                foreach (var x in list)
                    x.Invoice.CustomerName = x.CustomerName;

                return list.ConvertAll(x => x.Invoice);
            }
        }

    }
}
