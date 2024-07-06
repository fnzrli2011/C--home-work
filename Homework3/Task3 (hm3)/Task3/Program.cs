namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CapitalLetter("Men Feridem.Sen  kimsen");
        }
        public static void CapitalLetter(string s)
        {
            bool k = false;
            Console.Write(s[0]);
            foreach (char l in s)
            {
                if (k == true && char.IsLetter(l)==true)
                {
                    Console.Write(l);
                    k = false;
                }
                if (char.IsLetter(l)!=true)
                {
                    k= true;
                }
            }
        }
    }
}
