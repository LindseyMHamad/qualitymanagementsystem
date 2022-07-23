using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
   



    public class SpareParts
    {
        public decimal Qty { get; }
        public string Name { get; }
        public DateTime Date { get; }
        public DateTime MaintenanceDue { get; set; }
        public decimal AccuracyInStandard { get; }
        public decimal AccuracyInMetric { get; set; }

        //These lines are the constructor
        public SpareParts(decimal qty, string name, DateTime date, decimal accuracyinstandard)
        {
            Qty = qty;
            Name = name;
            AccuracyInStandard = accuracyinstandard;
            Date = date;
        }

        
    }


}
