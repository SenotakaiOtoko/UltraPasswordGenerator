using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraPasswordGenerator
{
    class Digits_and_letters : Dictionary
    {

        public override string ToString() { return "Буквы и цифры"; }

       public List<string> Get_dictionary()
        {
            List<string> Result = Properties.Resources.digits.Split().ToList();
            Result.AddRange(Properties.Resources.letters.Split().AsEnumerable());
           
            return Result;
        }
    }
}
