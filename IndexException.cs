using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{
    public class IndexException : Exception
    {
        public IndexException(string messge) : base(messge) { }
    }
}
