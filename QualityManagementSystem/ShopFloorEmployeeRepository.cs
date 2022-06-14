using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
    public class ShopFloorEmployeeRepository
    {
        public ShopFloorEmployee Retrieve(int shopflooremployeeid)
        {
            ShopFloorEmployee shopflooremployee = new ShopFloorEmployee(shopflooremployeeid);
            if (shopflooremployeeid == 1)
            {
                shopflooremployee.EmployeeName = "Lindsey";
                shopflooremployee.EmployeeLevelTrainer = 2;
                shopflooremployee.MonthsWorked = 24;
            }
            //code that retrieves the defined product
            return new ShopFloorEmployee();
        }



        public bool Save()
        {
            //code that saves the defined product
            return true;
        }
    }
}
