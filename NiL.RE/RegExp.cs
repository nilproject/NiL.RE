using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiL.RE
{
    public sealed class RegExp
    {
        private string source;
        private RegExpOptions flags;

        public RegExp()
        {
            source = "";
        }

        public RegExp(string pattern)
        {
            source = pattern;
        }

        public RegExp(string pattern, RegExpOptions options)
        {
            source = pattern;
            flags = options;
        }

        public ICollection<Match> Exec(string text)
        {
            throw new NotImplementedException();
        }

        public bool Test(string text)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string flags = "";
            if ((this.flags & RegExpOptions.Global) != 0)
                flags = "g";
            if ((this.flags & RegExpOptions.IgnoreCase) != 0)
                flags += "i";
            if ((this.flags & RegExpOptions.Multiline) != 0)
                flags += "m";
            return "/" + source + "/" + flags;
        }
    }
}
