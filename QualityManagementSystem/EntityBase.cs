using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityManagementSystem
{
   public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
    }
}
