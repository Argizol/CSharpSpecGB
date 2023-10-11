using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{ 
    internal abstract class Men : Human
    {
        Human _wife {  get; set; }

        public Men(string name, string surname, Enum sex, DateTime birthday)
            : base(name, surname, sex, birthday)
        {

        }

        void AddWife(Human wife)
        {
            _wife = wife;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
