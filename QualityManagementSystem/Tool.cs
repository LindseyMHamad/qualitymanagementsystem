using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
   public class Tool
    {
        public Tool() : this(0)
        {
            //this is a special method that is executed each time an instance of the class is created

        }

        public Tool(int machineId)
        {
            MachineId = machineId;

            Partlist = new List<Parts>();
        }


        public int MachineId { get; private set; }
        public string MachineName { get; set; }
        public int MachineType { get; set; }
        public int severity { get; set; }
        public int occurance { get; set; }
        public int RPN { get; set; }
        public List<Parts> Partlist { get; set; }

        


        public bool Valid()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(MachineName)) isValid = false;
            
            return isValid;
        }

        public List<Tool> Retrieve()
        {
            return new List<Tool>();
        }

       
    }

    
}
