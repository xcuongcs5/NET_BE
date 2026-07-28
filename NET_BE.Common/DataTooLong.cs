using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BE.Common
{
    public class DataTooLong : Exception
    {
        const string errorMessage = "Dữ liệu nhập vào quá dài, vui lòng nhập lại!";
        
        public DataTooLong() : base(errorMessage)
        {
        }
    }
}
