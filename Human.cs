using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{
    public enum Sex
    {
        male,
        female
    }
    internal class Human
    {
        string Name;
        string Surname;
        string Sex;
        DateTime Birthday;
        Human Father;
        Human Mother;
        List<Human> Childs;
        public Human(string name, string surname, Enum sex, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Sex = sex.ToString();
            Birthday = birthday;
        }
    }
}
