using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraPasswordGenerator
{
    class Only_digits:Dictionary
    {
        public override string ToString() { return "Только цифры"; }
        public List<string> Get_dictionary()
        {
            return Properties.Resources.digits.Split().ToList();
        }
    }
}
