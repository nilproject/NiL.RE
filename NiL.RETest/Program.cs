using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiL.RETest
{
    class Program
    {
        static void Main(string[] args)
        {
            new RE.RegExp("x").Test("x");
        }
    }
}
