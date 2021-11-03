using System;

namespace Testcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int num;
            num = 0;

            do
            {
               
                num++;
                numbers.Add(num);

            } while (num < 100);

           
            while (num < 200)
            {
              
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            foreach (var parts in numbers)
            {
                Console.WriteLine(parts);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");


        }
    }
}
