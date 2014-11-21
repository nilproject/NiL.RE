using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiL.RE
{
    /// <summary>
    /// *
    /// +
    /// ?
    /// { DecimalDigits }
    /// { DecimalDigits , }
    /// { DecimalDigits , DecimalDigits }
    /// </summary>
    internal struct Quantifier
    {
        public readonly int Minimum;
        public readonly int Maximum;
        public readonly bool Greedy;

        public Quantifier(int min, int max, bool greedy)
        {
            Minimum = min;
            Maximum = max;
            Greedy = greedy;
        }
    }
}
