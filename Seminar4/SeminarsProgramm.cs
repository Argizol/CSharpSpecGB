//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpSpecGB.Seminar4
//{
//    internal class SeminarsProgramm
//    {
//        //Задача 1: Фильтрация и проекция данных с использованием LINQ
////Предоставьте студентам некоторую коллекцию объектов (например, список студентов) и попросите их решить следующие задачи:

////Найти всех студентов, чей возраст меньше 25 лет.
////Вывести имена всех студентов в алфавитном порядке.
////Выбрать студентов, обучающихся на факультете инженерии.
////Посчитать средний возраст студентов.
////Попросите студентов использовать LINQ для решения этих задач.

//using CSharpSpecGB;
//using CSharpSpecGB.Seminar4;
//using System.Threading.Channels;

//List<Student> students = new List<Student>
//{
//    new Student { Name = "Alice", Age = 22, Faculty = "Engineering" },
//    new Student { Name = "Bob", Age = 25, Faculty = "Science" },
//    new Student { Name = "Charlie", Age = 19, Faculty = "Engineering" },
//    new Student { Name = "David", Age = 30, Faculty = "Arts" },
//    new Student { Name = "Eve", Age = 21, Faculty = "Science" },
//    // Добавьте других студентов по вашему усмотрению
//};

//    var filteredStudent = students.Where(x => x.Age < 25).ToList();
//    filteredStudent.ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
//Console.WriteLine();

//var alfabetOrdered = students.OrderBy(x => x.Name).Select(x => x.Name).ToList();
//    alfabetOrdered.ForEach(Console.WriteLine);
//Console.WriteLine();

//var findEngeeneer = students.Where(x => x.Faculty.Equals("Engineering")).ToList();
//    findEngeeneer.ForEach(x => Console.WriteLine($"{x.Name} {x.Faculty}"));
//Console.WriteLine();

//var averageAge = students.Average(x => x.Age);
//    Console.WriteLine(averageAge);


//List<Order> orders = new List<Order>
//{
//    new Order { OrderID = 1, CustomerName = "Alice", OrderDate = new DateTime(2023, 6, 1), TotalAmount = 150.0 },
//    new Order { OrderID = 2, CustomerName = "Bob", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 75.5 },
//    new Order { OrderID = 3, CustomerName = "Charlie", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 220.0 },
//    new Order { OrderID = 4, CustomerName = "David", OrderDate = new DateTime(2023, 6, 3), TotalAmount = 100.0 },
//    new Order { OrderID = 5, CustomerName = "Eve", OrderDate = new DateTime(2023, 6, 4), TotalAmount = 85.5 },
//    // Добавьте другие заказы по вашему усмотрению
//};

//    //Отсортировать заказы по сумме в убывающем порядке.
//    var orderedBtAmountDesc = orders.OrderByDescending(a => a.TotalAmount).ToList();
//    orderedBtAmountDesc.ForEach(b => Console.WriteLine($"{b.CustomerName} {b.TotalAmount}"));
//Console.WriteLine();


////var orderedBtAmountDesc2 = from order in orders
////                           orderby order.TotalAmount
////                           select order;

////Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента.
//var groupedByClient = orders.GroupBy(z => z.CustomerName)
//    .Select(y => new { name = y.Key, Count = y.Count() }).ToList();
//    groupedByClient.ForEach(x => Console.WriteLine($"{x.name} {x.Count}"));
//Console.WriteLine();


////Найти клиента с наибольшей суммой заказов.
//var richestClient = orders.GroupBy(x => x.CustomerName)
//    .Select(x => new { name = x.Key, sumTotalAm = x.Sum(ta => ta.TotalAmount) })
//    .OrderBy(ta => ta.sumTotalAm)
//    .Last().name.ToString();
//    Console.WriteLine(richestClient);
//Console.WriteLine();


////Вывести список клиентов и общую сумму их заказов.
//var sumByClientsOrder = orders.GroupBy(x => x.CustomerName)
//    .Select(x => new { name = x.Key, sumTotalAm = x.Sum(ta => ta.TotalAmount) }).ToList();
//    sumByClientsOrder.ForEach(x => Console.WriteLine($"{x.name} {x.sumTotalAm}"));
//Console.WriteLine();

////В этой задаче у вас есть список строк, и ваша задача – отсортировать этот список
////в порядке возрастания длины строк, используя лямбда-выражение.
////Ниже приведены начальные данные:

//List<string> strings = new List<string>
//        {
//            "Apple",
//            "Banana",
//            "Cherry",
//            "Date",
//            "Fig",
//            "Grapes"
//        };

//    strings.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);

//    var numbersList = new List<int>() { 71, 25, 31, 4, 7, 12, 22, 0, 1 };

//    numbersList.Sort();
//numbersList.ForEach(Console.WriteLine);


////выбрать все строки, содержащие определенную подстроку,
////с использованием лямбда-выражения. Вот начальные данные и решение задачи:
//List<string> words = new List<string>
//        {
//            "apple",
//            "banana",
//            "cherry",
//            "date",
//            "grape",
//            "kiwi",
//            "lemon",
//        };

//    string searchTerm = "an";

//    words.Where(x => x.Contains(searchTerm)).ToList().ForEach(Console.WriteLine);

//    //у нас есть список чисел, и мы хотим умножить каждое число в списке на 2, используя анонимный метод
//    var numbersList2 = new List<int>() { 71, 25, 31, 4, 7, 12, 22, 0, 1 };
//    numbersList2.Select(x => x* 2).ToList().ForEach(Console.WriteLine);


//    orders.Where(y => y.CustomerName.StartsWith('A')).ToList().ForEach(x => Console.WriteLine($"{x.CustomerName}"));

////Поиск общих элементов в двух коллекциях


//HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };
//    List<int> list = new List<int> { 3, 4, 5, 6, 7 };

//    var intersect = hashSet.Intersect(list);
//foreach (int x in intersect) {  Console.WriteLine(x); }
//    }
//}
