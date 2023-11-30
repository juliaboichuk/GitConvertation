using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConvertation
{
    internal class Bits: IBits
    {
        public long Value { get; set; }

        public Bits(long value)
        {
            Value = value;
        }

        public static implicit operator Bits(byte x) => new(x);
        public static implicit operator Bits(int x) => new(x);
        public static implicit operator Bits(long x) => new(x);

        public static explicit operator long(Bits bits) => bits.Value;

        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }
        }

        public bool this[byte index]
        {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }
    }
}
