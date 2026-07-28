using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess
{
    public static class UserInput
    {
        public static void UserInputLength(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new NET_BE.Common.DataTooLong();
                throw e;
            }
        }
    }
}
