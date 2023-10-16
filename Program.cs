using CSharpSpecGB;
using System.Text;

var value = new Bits(7);

StringBuilder sb = new StringBuilder();
try
{
    for (int i = 0; i < 8; i++)
    {
        sb.Append(value.GetBit(i) ? 1 : 0);
    }

    Console.WriteLine(sb.ToString());
    Console.WriteLine(value.GetBit(2));

    value.SetBit(false, 2);
    Console.WriteLine(value.Value);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




