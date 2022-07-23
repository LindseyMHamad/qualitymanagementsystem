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


        public Machine(string name, decimal Qty, decimal accuracyinstandard)
        {
            machineName = name;
            replaceMachineParts(Qty, name, accuracyinstandard, DateTime.Now);
            this.machineNumber = machineID.ToString();
            machineID++;

        }

        public void replaceMachineParts(decimal qty, String name, decimal accuracyinstandard, DateTime date)
        {
            if (qty <=0)
            {
                Console.Write("Qty must be positive!");
            }
            var replacepart = new SpareParts(-qty, name, date, accuracyinstandard);
                listofspareparts.Add(replacepart);
        }

        public void addToList(decimal qty, String name, decimal accuracyinstandard, DateTime date)
        {
            var sparepartslist = new SpareParts(qty, name, date, accuracyinstandard);
            listofspareparts.Add(sparepartslist);


        }

        public void listofSpareParts()
        {
            //var report = new System.Text.StringBuilder();
            //report.AppendLine("Qty\t\tName\tDate\tAccuracyintStandard");

            foreach(var item in listofspareparts)
            {
                //report.AppendLine($" {item.Qty} \t {item.Name} \t {item.Date} \t {item.AccuracyInStandard} ");
                Console.WriteLine(item);
            }

            
        }

       
       
    }
}
