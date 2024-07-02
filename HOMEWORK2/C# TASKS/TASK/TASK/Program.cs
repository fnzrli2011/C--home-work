using System.Collections.Immutable;
using System.Security.Cryptography;

namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var student1 = new { Name = "Farid", grade = 100, age = 12 };
            //var student2 = new { Name = "Ayten", grade = 100, age = 20 };
            //var student3 = new { Name = "Aynur", grade = 100, age = 20 };
            ////Console.WriteLine(student2.age);
            //var student = new[] { student1, student2, student3 };
            //foreach (var item in student)
            //{
            //    Console.Write($"{item.Name}  ");
            //    Console.Write($"{item.grade}  ");
            //    Console.WriteLine($"{item.age}  ");
            //}



            //Task1.1:
            //long[] numbers = { 1, 2, 3, 3, 5, 2, 7, 4 };
            //long k = numbers.Max();
            //Console.WriteLine(k);


            //Task 1.2:
            //var product1 = new { ID = 12, Name = "cofee", Prise = 0.50, StockCount = 100 };
            //var product2 = new { ID = 13, Name = "choclate", Prise = 2.50, StockCount = 200 };
            //var product3 = new { ID = 14, Name = "milk", Prise = 10.50, StockCount = 70 };
            //var product4 = new { ID = 15, Name = "cips", Prise = 3.50, StockCount = 100 };
            //var Products = new[] { product1, product2, product3, product4 };
            //long  say = 0;
            //double edediorta, cem = 0;
            //foreach (var product in Products)
            //{
            //    long n = product.ID;
            //    if(n%2==1)
            //    {
            //        say++;
            //        cem = product.Prise+cem;
            //    }
            //}
            //edediorta = cem / say;
            //Console.WriteLine(edediorta);



            //Task 1.3:
            //string s = "Programming";
            //char[] letters = new char[s.Length + 1];
            //for (int i = 0; i < s.Length; i++)
            //{
            //    letters[i] = s[i];
            //}
            //letters[s.Length] = 'z';
            //Array.Sort(letters);
            //char c = '-';
            //long say = 0;
            //foreach (char letter in letters)
            //{
            //    if (letter != c)
            //    {
            //        say++;
            //        if (say != 0)
            //        {
            //            if (c != '-')
            //            { Console.WriteLine($"{c}:{say}"); }
            //            c = letter;
            //            say = 0;
            //        }
            //    }
            //    else
            //    {
            //        say++;
            //    }
            }
        }
    }
}

