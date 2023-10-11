using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpSpecGB
{
    internal class Woman : Human
    {
        Human _husband { get; set; }

        public Woman(string name, string surname, Enum sex, DateTime birthday)
            : base(name, surname, sex, birthday)
        { 
            
        }

        void AddHusband(Human husband)
        {
            _husband = husband;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
