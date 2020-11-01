using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Drink
{
    public class Beer : Drink
    {
        public override string Name { get; set; }
        public override string IsCarbonated { get; set; }
        private double Content { set; get; }


        public Beer(string _name, string _isCarbonated, double _content)
        {
            Name = _name;
            IsCarbonated = _isCarbonated;
            Content = _content;
        }

        public override string description()
        {
            return string.Format("{0}, {1}, {2}", Name, IsCarbonated, Content);
        }
    }
}
