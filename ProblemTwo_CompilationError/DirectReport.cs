using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport:Employee
    {
        public Employee ReportsTo { get; set; }
        public List<Manager> managerEmpobj { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(int eID, String eName, int eLevel, DateTime eDoJEmployee , List<Manager>managerEmpObj, string pCode)
        {
 
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }

   
}
