using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
    class Machine
    {
        private static int machineID = 1234567890;
        public string machineName;
        public string machineNumber;
        public int levelEmployee;
        public decimal accuracyStandard;
        public DateTime CalibrationDate;
        public DateTime CalibrationFrequency;

        public List<SpareParts> listofspareparts = new List<SpareParts>();


        public Machine(string name, decimal Qty, double lengthinstandard, double accuracyinmetric, DateTime maintenancedue)
        {
            machineName = name;
            //replaceMachineParts(Qty, name, accuracyinstandard, accuracyinmetric, DateTime.Now, maintenancedue);
            this.machineNumber = machineID.ToString();
            machineID++;

        }

      

        public void addToList(decimal qty, String name, double lengthinstandard, double accuracyinmetric, DateTime date, DateTime maintenancedue)
        {
            var sparepartslist = new SpareParts(qty, name, date, lengthinstandard, accuracyinmetric, maintenancedue);
            listofspareparts.Add(sparepartslist);

            
        }

        public string listofSparePartsPrint()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Qty\t\tName\t\t Date\t \t Maintenance Due \t \t AccuracyintStandard \t \t Accuracy in Metric");

              foreach(var item in listofspareparts)
             {
               report.AppendLine($" {item.Qty} \t \t {item.Name} \t \t {item.Date} \t \t {item.MaintenanceDue} \t \t {item.LengthInStandard} \t \t {item.AccuracyInMetric}");
          
              }
            return report.ToString();
            //  listofspareparts.ForEach(i => Console.WriteLine"{0}\t", i);
        }

        

    }

   
}
