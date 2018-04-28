using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using RomanNumberConverter;

namespace KingSort.Sorters {
    public class King {
        public String Name { get; private set; }
        public String Number { get; private set; }
        public int NumberValue { get; private set; }

        public King(string king) {
            Number = GetRomanNumber(king);
            NumberValue = GetRomanNumberValue(Number);
            Name = GetKingName(king, Number);
        }

        public int GetRomanNumberValue(String Number) {
            return RomanNumberConverter.RomanNumberConverter.RomanToInteger(Number);
        }

        public String GetRomanNumber(String king) {
            return Regex.Match(king, @"\S*[IVXL]$").Value;
        }

        public String GetKingName(String king, String number) {
            if(number.Length > 0) return king.Substring(0, king.Length - number.Length - 1);
            return king.Substring(0, king.Length - number.Length);
        }
    }
}
