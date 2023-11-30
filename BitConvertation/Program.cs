namespace BitConvertation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteNumber = 1;
            int intNumber = 2;
            long longNumber = 3;

            Bits bits = new Bits(4);
            longNumber = (long)bits;
            Console.WriteLine("Bits to Long: " + longNumber);
            bits = byteNumber;
            Console.WriteLine("Byte to Bits: " + bits.Value);
            bits = intNumber;
            Console.WriteLine("Int to Bits: " + bits.Value);
            bits = longNumber;
            Console.WriteLine("Long to Bits: " + bits.Value);
        }
    }
}