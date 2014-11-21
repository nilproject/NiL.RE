using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiL.RE
{
    internal static class Builder
    {
        private static readonly char[] controlLetter = new[]
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        private static bool isCharacterClassEscape(char c)
        {
            switch (c)
            {
                case 'd':
                case 'D':
                case 's':
                case 'S':
                case 'w':
                case 'W':
                    return true;
            }
            return false;
        }

        private static bool isControlEscape(char c)
        {
            switch (c)
            {
                case 'f':
                case 'n':
                case 'r':
                case 't':
                case 'v':
                    return true;
            }
            return false;
        }

        private static bool isPatternCharacter(char c)
        {
            switch (c)
            {
                case '^':
                case '$':
                case '\\':
                case '.':
                case '*':
                case '+':
                case '?':
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '|':
                    return false;
            }
            return true;
        }

        internal RegExpTreeNode Build(string pattern)
        {
            return null;
        }

        private static RegExpTreeNode parseBlock(string source, int index)
        {

        }
    }
}
