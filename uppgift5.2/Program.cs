using System;
namespace Uppgift_5._2
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur mycket heltal vill du skriva");
            int tal = int.Parse(Console.ReadLine());
            int[] talet = new int[tal];

            for (int i = 0; i < tal; i++)
            {
                talet[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < talet.Length; i++)
                Console.WriteLine(talet[i]);
        }
    }
}