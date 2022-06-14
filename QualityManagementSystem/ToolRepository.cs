using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
    public class ToolRepository
    {
        public Tool Retrieve(int MachineId)
        {
            Tool tool = new Tool(MachineId);

            if (MachineId == 1)
            {
                tool.MachineName = "Cutter";
                tool.severity = 4;
                tool.RPN = 1;
                tool.occurance = 2;
            }
            //Code that retrieves the defined Tool
            return new Tool();
        }


        public bool Save()
        {
            return true;
        }
    }
}
