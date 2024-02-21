using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    public class SocialSecurityNumber
    {
        private string _ssn;

        public string SSn
        {
            get { return _ssn; }
            set
            {
                string pattern = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$";
                if (Regex.IsMatch(value, pattern))
                {
                    _ssn = value;
                }
                else
                {
                    throw new SSNFormatException();
                }

            }
        }


    }
}
