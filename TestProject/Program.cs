using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            string temp = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0, 1).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds.ToString();
            Console.WriteLine(temp);
            try
            {
                int x = 2;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Data.ToString());
            }
            Console.Read();
        }
    }
}
