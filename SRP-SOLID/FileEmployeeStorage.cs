using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_SOLID
{
    public class FileEmployeeStorage : IEmployeeStorage, IEditableEmployeeStorage
    {
        private List<Employee> _employees;

        public FileEmployeeStorage()
        {
            _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Thang", Age = 21 },
            new Employee { Id = 2, Name = "Quoc Cuong", Age = 24 },
            new Employee { Id = 3, Name = "ChiTrump", Age = 27 }
        };
        }

        public void Store(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }
        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }
    }
}
