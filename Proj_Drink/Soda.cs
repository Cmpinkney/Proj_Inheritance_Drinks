using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Drink
{
    public class Soda : Drink 
    {
        public override string Name { get; set; }
        public override string IsCarbonated { get; set; }


        public Soda(string _name, string _isCarbonated)
        {
            Name = _name;
            IsCarbonated = _isCarbonated;
        }

        public override string description()
        {
            return string.Format("{0}, {1}", Name, IsCarbonated);
        }
    }
}
