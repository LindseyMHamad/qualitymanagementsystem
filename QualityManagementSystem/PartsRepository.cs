using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
    public class PartsRepository
    {
        public Parts Retrieve(int partnumberid)
        {
            Parts part = new Parts(partnumberid);
            if (partnumberid==1)
            {
                part.PartName = "90 deg valve";
                part.PurchasePrice = 1.50M;
                part.NumberofVariations = 5;
                part.Revision = 'b';
            }

            return part;
        }

        public bool Save()
        {
            //code that saves the defined product
            return true;
        }
    }
}
