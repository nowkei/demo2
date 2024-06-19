using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_SOLID
{
    public interface IEmployeeStorage
    {
        void Store(Employee employee);
        List<Employee> GetAllEmployees();
    }
}
