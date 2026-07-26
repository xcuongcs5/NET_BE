using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a month (1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //int days;

            //switch(month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month");
            //        return;
            //}
            //Console.WriteLine("Number of days in month {0}: {1}", month, days);

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("i = {0}", i);
            }

            //Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
