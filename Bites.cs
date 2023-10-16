namespace CSharpSpecGB
{
    //Реализуйте операторы неявного приведения из long,int,byt в Bits.
    internal class Bits
    {
        byte Value { get; set; }
        public Bits(byte bits) { Value = bits; }
        public static implicit operator byte(Bits bits)
        {
            return new Bits(Convert.ToByte(bits));
        }
        public static implicit operator long(Bits bits)
        {
            return new Bits(Convert.ToByte((bits)));
        }
        public static implicit operator int(Bits bits)
        {
            return new Bits(Convert.ToByte((bits)));
        }
        public static explicit operator Bits(byte bits) => new Bits(bits);

    }


}

