﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpSpecGB
{
    internal class Woman : Human
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Sex { get; set; }
        DateTime Birthday { get; set; }
        Human Father { get; set; }
        Human Mother { get; set; }
        List<Human> Childs { get; set; }

        public Woman(string name, string surname, Enum sex, DateTime birthday) : base()
        { 
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
