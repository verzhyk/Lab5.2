using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaVlad
{
    public class BadException : Exception
    {
        public BadException(string message) : base(message)
        {
            
        }
    }
}
