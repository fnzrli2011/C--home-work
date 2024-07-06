namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WithoutSpace(" Salam 1 2 3 ");
        }
        public static void WithoutSpace(string s)
        {
            foreach (char l in s)
            {
                if(l!=' ')
                {
                    Console.Write(l);
                }
            }
        }
    }
}
