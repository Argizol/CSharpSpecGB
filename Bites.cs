using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{
    //Реализуйте операторы неявного приведения из long,int,byt в Bits.
    internal class Bits
    {
        byte Value { get; set; }
        public Bits(byte bits) { this.Value = bits}
        public static implicit operator byte(Bits bits) => bits.Value;
        public static implicit operator long(Bits bits) => bits.Value;
        public static implicit operator int(Bits bits) => bits.Value;
        public static explicit operator Bits(byte bits) => new Bits(bits);

    }
}

