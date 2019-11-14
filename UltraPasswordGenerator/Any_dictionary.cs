using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraPasswordGenerator
{
    class Any_dictionary:Dictionary
    {
        public override string ToString() { return "Произвольный"; }
        public List<string> Get_dictionary()
        {
            List<string> Result = Properties.Resources.dictionary.Split().ToList();
            Result.AddRange(Properties.Resources.letters.Split().AsEnumerable());
            Result.AddRange(Properties.Resources.digits.Split().AsEnumerable());
            Result.AddRange(Properties.Resources.symbols.Split().AsEnumerable());
            return Result;
        }
    }
}
