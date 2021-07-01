using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (brackets >= 0)
                {
                    if (ch == '[')
                    {
                        brackets++;
                    }
                    else if (ch == ']')
                    {
                        brackets--;
                    }
                }
                else
                {
                    return false;
                }
                
            }
            return brackets == 0;
        }
        public static bool UnBalancedBracketsHasClosingBracketsFirst(String str)
        {
            int brackets = 0;
            int i = 0;
            int indexOpening = i;
            int indexClosing = i;
            foreach (char ch in str.ToCharArray())
            {
                if(ch == '[')
                {
                    indexOpening = i;
                    brackets++;
                    i++;
                }
                else if(ch == ']')
                {
                    indexClosing = i;
                    brackets--;
                    i++;
                }
                else
                {
                    i++;
                }

                if(indexClosing < indexOpening && brackets == 0)
                {
                    return false;
                }
                else if(indexOpening < indexClosing && brackets == 0)
                {
                    return true;
                }
            }
                return true; //no brackets
        }
    }
}
