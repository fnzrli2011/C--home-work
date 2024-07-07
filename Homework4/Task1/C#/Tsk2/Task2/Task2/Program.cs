using System.Security.Cryptography;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "salam";
           
        }

        public static void Trim(string s)
        {
            long  d;
            char c = Convert.ToChar(Console.ReadLine());
           int k=s.IndexOf(c);
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(s[i]);
            }
            
        }
    }
}
