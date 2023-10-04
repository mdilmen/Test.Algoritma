using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Algoritma
{
    public class TesterEnhanced
    {
        private readonly Dictionary<char, char> _oppositeChars = new()
        {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

        public bool IsValid(string? value)
        {
            if (value == null || value.Length % 2 != 0)
            {
                return false;
            }

            var halfLength = value.Length / 2;
            for (int i = 0; i < halfLength; i++)
            {
                char openingChar = value[i];
                char closingChar = value[value.Length - 1 - i];

                if (!_oppositeChars.TryGetValue(openingChar, out char expectedClosingChar) || closingChar != expectedClosingChar)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
