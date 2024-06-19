using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_SOLID
{
    public interface IEditableEmployeeStorage
    {
        void Delete(Employee employee);
    }
}
