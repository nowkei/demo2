using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_SOLID
{
    public class EmployeeManager
    {
        private readonly IEmployeeStorage _employeeStorage;

        public EmployeeManager(IEmployeeStorage employeeStorage)
        {
            _employeeStorage = employeeStorage;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeStorage.Store(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeStorage.GetAllEmployees();
        }
        public void DeleteEmployee(Employee employee)
        {
            if (_employeeStorage is IEditableEmployeeStorage editableStorage)
            {
                editableStorage.Delete(employee);
            }
            else
            {
                Console.WriteLine("ko dc dau be oi=))");
            }
        }
    }
}
