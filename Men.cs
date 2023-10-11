using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{ 
    internal abstract class Men : Human
    {

        public Men(string name, string surname, Enum sex, DateTime birthday) : base()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
