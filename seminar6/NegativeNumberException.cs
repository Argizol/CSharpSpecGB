using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB.seminar6
{
    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
           
        }
        public NegativeNumberException(string message ) : base( message )
        {

        }
        public NegativeNumberException(string message, Exception e) : base(message, e)
        {

        }
    }
}
