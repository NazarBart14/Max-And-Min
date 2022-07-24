using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"");
            int size = Convert.ToInt32(Console.ReadLine());
          
            Random random = new Random();
            var arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.WriteLine($"{arr[i]}");
              
            }
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"Min = {arr.Min()}");
            Console.WriteLine($"Sum = {arr.Sum()}");
           



        }
    }
}