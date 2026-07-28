using BE.DataAccess;
using NET_BE.Common;
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
            //BE.DataAccess.Bai1.AddTwoNumbers();
            //BE.DataAccess.Bai1.SubtractTwoNumbers();
            //BE.DataAccess.Bai1.MultiplyTwoNumbers();
            //NET_BE.Common.ValidateData.chia_hai_so();

            try
            {
                BE.DataAccess.UserInput.UserInputLength("Day la chuoi duoc truyen vao tu ConsoleApp");
            }
            catch (DataTooLong e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception otherException)
            {
                Console.WriteLine(otherException.Message);
            }

            Console.ReadKey();
        }
    }
}
