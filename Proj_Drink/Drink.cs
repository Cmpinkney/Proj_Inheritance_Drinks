using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Drink
{
    public abstract class Drink
    {
        public abstract string Name { get; set; }
        public abstract string IsCarbonated { get; set; }

        public virtual string description()
        {
            return string.Format("{0}, {1}", Name, IsCarbonated);
        }
    }
}
