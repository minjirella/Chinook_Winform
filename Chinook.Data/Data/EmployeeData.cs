using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class EmployeeData:EntityData<Employee>
    {
        public Employee GetByPK(int employeeId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            }
        }

        public void DeleteByPK(int employeeId)
        {
            Employee entity = GetByPK(employeeId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Employee> GetAllOrderByLastName()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Employees
                            orderby x.LastName
                            select x;

                return query.ToList();
            }
        }
    }
}
