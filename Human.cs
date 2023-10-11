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

        public Human()
        {
        }

        public Human(string name, string surname, Enum sex, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Sex = sex.ToString();
            Birthday = birthday;
        }

        string PrintFather()
        {
            return $" Отец = " +
                $"Имя = {Father.Name} \n" +
                $" Фамилия = {Father.Surname}" +
                $" \n Пол = {Father.Sex}\n" +
                $"Дата рождения = {Father.Birthday}"; 
        }

        string PrintMother()
        {
            return $" Отец = " +
                $"Имя = {Mother.Name} \n" +
                $" Фамилия = {Mother.Surname}" +
                $" \n Пол = {Mother.Sex}\n" +
                $"Дата рождения = {Mother.Birthday}";
        }

        void PrintChilds()
        {
            if (Childs.Count > 0)
            {
                foreach (var child in Childs)
                {
                    Console.WriteLine(child);
                }
            }
            
        }

        public override string ToString()
        {
            return $"Имя = {Name}" +
                $" \n Фамилия = {Surname}" +
                $" \n Пол = {Sex}\n" +
                $"Дата рождения = {Birthday}";
                
        }
    }
}
