namespace ODEV4_Fibonacci_Pascal_Ucgeni
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Lütfen Satır Sayısını Giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < satir; i++)
            {
                int c = 1;
                for (int e = 0; e < satir - i; e++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("    {0} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

