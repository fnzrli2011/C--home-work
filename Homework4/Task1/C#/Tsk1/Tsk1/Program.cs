namespace Tsk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=" ";
            ValidatePassword(s);
        }
        public static void ValidatePassword(string s)
        {
           
            while (true)
            {
               
                Console.WriteLine("Create Pasword");
                s = Console.ReadLine();
                long sayi = 0, sayd = 0;
                if (s.Length < 8 || char.IsLetter(s[0])==false && char.IsUpper(s[0])==false)
                {
                    Console.WriteLine("False");
                    Console.WriteLine("Try again");
                }
                else
                {
                    foreach (char l in s)
                    {
                        if (char.IsDigit(l) == true)
                        {
                            sayd++;
                        }
                        if (char.IsLetterOrDigit(l) == false)
                        {
                            sayi++;
                        }
                    }
                    if (sayi >= 1 && sayd >= 1)
                    {
                        Console.WriteLine("True");
                        Console.WriteLine("Acses");
                        break;
                    }
                }
            }
        }
    }
}
