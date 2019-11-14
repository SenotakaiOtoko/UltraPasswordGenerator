using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraPasswordGenerator
{
    class Easy_dictionary : Dictionary
    {
        public override string ToString() {return "Запоминающийся";}
        
        public List<string> Get_dictionary()
        {
  
            List<string> Result = Properties.Resources.dictionary.Split().ToList();
            Result.AddRange(Properties.Resources.letters.Split().AsEnumerable());
            Result.AddRange(Properties.Resources.digits.Split().AsEnumerable());
            return Result;
        }
    }
}
