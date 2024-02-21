using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    public class SSNFormatException:Exception
    {
        public SSNFormatException(): base("Not a valid Social Security Number.")
        {
        }
        public SSNFormatException(string message) : base(message)
        {
        }


    }
}
