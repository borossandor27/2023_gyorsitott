using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_04_sync_async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            method01();
            method02();
            method01();
            Console.WriteLine("\nProgram vége");
            Console.ReadLine();

        }

        public static void method01()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("01");
                Task.Delay(100).Wait();
            }
        }
        public static async Task method02()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("02");
                    Task.Delay(100).Wait();

                }
            });
        }
    }
}
