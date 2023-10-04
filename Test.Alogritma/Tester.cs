using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Algoritma
{
    public class Tester
    {
        private readonly List<OppositeChar> _listOpposites;
        public Tester()
        {
            _listOpposites = new List<OppositeChar>
        {
            new OppositeChar { Value = "(", OppositeValue = ")" },
            new OppositeChar { Value = "{", OppositeValue = "}" },
            new OppositeChar { Value = "[", OppositeValue = "]" }
        };

        }
        public bool IsValid(string? value)
        {            
            if (value == null || value.Length % 2 != 0) return false;            
            var halfLength = value.Length / 2;


            List<CharInsideValue> charInsideValueList = new();
            for (int i = 0; i < value.Length; i++)
            {
                CharInsideValue charInsideValue = new()
                {
                    Value = value.Substring(i, 1),
                    Order = i,
                    OppositeValue = FindOppositeChar(value.Substring(i, 1))
                };                
                charInsideValueList.Add(charInsideValue);
            }

            for (int z = 0; z < halfLength; z++)
            {
                var myChar = charInsideValueList.Where(c => c.Order == z).First();
                var myCharOpposite = charInsideValueList.Where(c => c.Order == value.Length - 1 - z).First();
                if (myChar.OppositeValue is not null && myCharOpposite.Value is not null)
                {
                    if (!myChar.OppositeValue.Equals(myCharOpposite.Value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public string? FindOppositeChar(string? value)
        {
            if (value is not null)
            {
                var oppositeChar = _listOpposites.FirstOrDefault(op => value.Equals(op.Value));
                if (oppositeChar is not null)
                {
                    return oppositeChar.OppositeValue;
                }
            }
            return null;
        }
    }
    public class CharInsideValue
    {
        public string? Value { get; set; }
        public int Order { get; set; }
        public string? OppositeValue { get; set; } = null;
    }
    public class OppositeChar
    {
        public string? Value { get; set; }
        public string? OppositeValue { get; set; }

    }
}
