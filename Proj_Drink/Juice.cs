using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Drink
{
    public class Juice : Drink
    {
        private string Made { get; set; }
        public override string Name { get; set; }
        public override string IsCarbonated { get; set; }
        public Juice(string _name, string _isCarbonated, string _made)
        {
            Name = _name;
            IsCarbonated = _isCarbonated;
            Made = _made;
        }

        public override string description()
        {
            return string.Format("{0}, {1}, {2}", Name, IsCarbonated, Made);
        }

    }
}
