using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConvertation
{
    internal interface IBits
    {
        bool GetBitByIndex(byte index);
        void SetBitByIndex(byte index, bool value);
    }
}
