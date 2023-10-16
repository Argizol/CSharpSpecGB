namespace CSharpSpecGB
{
    //Реализуйте операторы неявного приведения из long,int,byt в Bits.
    internal class Bits
    {
        byte Value { get; set; }        
        public Bits(byte bits) { Value = bits; }
        public static implicit operator Bits(byte bits) => new Bits(bits);
        public static implicit operator Bits(long bits)
        {
            return new Bits(Convert.ToByte(bits));
        }
        public static implicit operator Bits(int bits)
        {
            return new Bits(Convert.ToByte(bits));
        }
    }
}

