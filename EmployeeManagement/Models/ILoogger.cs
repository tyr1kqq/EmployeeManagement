using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    interface ILoogger
    {
        void WriteError(string errorMessage);
        void WriteEvent(string eventMessage);
            
    }
}
