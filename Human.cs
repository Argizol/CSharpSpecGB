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
       internal string Name { get; set; }
       internal string Surname { get; set; }
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
            Childs = new List<Human>();
        }

        void AddChild(Human child)
        {
            Childs.Add(child);
        }

        void AddFather(Human father)
        {
           Father = father;
        }
        void AddMother(Human mother)
        {
            Mother = mother;
        }


        string PrintInfo()
        {
            return $" {this} ";
        }
        string PrintFather()
        {
            return $" Отец =\n" +
                $" {Father} ";
        }

        string PrintMother()
        {
            return $" Мать = {Mother}";
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

        void PrintGenealogicTree()
        {
            PrintInfo();

            while (Father.Name is not null || Mother.Name is not null)
            {
                if (Father is not null)
                    PrintFather();

                if (Mother is not null)
                    PrintMother();

                PrintGenealogicTree();
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
