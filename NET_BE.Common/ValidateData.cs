using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BE.Common
{
    public static class ValidateData
    {
        public static bool CheckInput(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber))
            {
                return false;
            }

            inputNumber = inputNumber.Trim();

            if (!int.TryParse(inputNumber, out int num))
            {
                return false;
            }

            int numberInput = int.Parse(inputNumber);

            if (numberInput > int.MaxValue)
            {
                return false;
            }

            return true;
        }

        public static int chia_hai_so()
        {
            try
            {
                int a = 10;
                int b = 0;
                return a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
    }
}
