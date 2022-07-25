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
        public double LengthInStandard { get; }
        public double AccuracyInMetric { get; set; }
       

        //These lines are the constructor
        public SpareParts(decimal qty, string name, DateTime date, double lengthinstandard, double accuracyinmetric, DateTime maintenancedue)
        {
            Qty = qty;
            Name = name;
            LengthInStandard = lengthinstandard;
            Date = date;
            AccuracyInMetric = accuracyinmetric;
            MaintenanceDue = maintenancedue;
        }

        
    }


}
