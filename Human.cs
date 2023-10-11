using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{
    internal class Human
    {
        string Name;
        string Surname;
        string Sex;
        DateTime Birthday;
        List<Human> Relatives;
        List<Human> Childs;
        public Human(string name, string surname, string sex, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Birthday = birthday;
        }
    }
}
