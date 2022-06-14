using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
    public class Parts
    {

        public Parts()
        {

        }

        public Parts(int partnumberid)
        {
            PartNumberId = partnumberid;
        }

        public int PartNumberId { get; private set; }
        public string PartName { get; set; }
        public decimal PurchasePrice { get; set; }
        public int NumberofVariations { get; set; }
        public char Revision { get; set; }

              

        public bool Valid()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(PartName)) isValid = false;
            //if the string for the employee name is null or whitespace the isValid changes from true to false
            return isValid;
        }
    }
}
