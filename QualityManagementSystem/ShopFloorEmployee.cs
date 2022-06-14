using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
    public class ShopFloorEmployee
    {

        public ShopFloorEmployee()
        {
            //this is a special method that is executed each time an instance of the class is created

        }

        public ShopFloorEmployee(int employeeid)
        {
            EmployeeID = employeeid;
        }

        public int EmployeeID { get; private set; }
        public string EmployeeName { get; set; }
        public int EmployeeLevelTrainer { get; set; }
        public decimal? MonthsWorked { get; set; } // the question mark by the decimal word tells C# that a value of zero is a valid option


        

        public bool Valid()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(EmployeeName)) isValid = false;
            //if the string for the employee name is null or whitespace the isValid changes from true to false
            return isValid;
        }
    }
}
