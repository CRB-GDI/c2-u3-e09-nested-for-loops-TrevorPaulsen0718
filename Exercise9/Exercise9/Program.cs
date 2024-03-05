namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Problem 2  
            Console.Write("Width: ");
            int width2 = int.Parse(Console.ReadLine());
            for (int i2 = -1; i2 < width2; i2++)
            {
                for (int j2 = -1; j2 < i2; j2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}