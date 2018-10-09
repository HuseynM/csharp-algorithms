using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.conditional_statements
{
    public class AzWord
    {
        private static string[] _singleDigit = { "bir ", "iki ", "üç ", "dörd ", "beş ", "altı ", "yeddi ", "səkkiz ", "doqquz " };
        private static string[] _doubleDigit = { "on ", "iyirmi ", "otuz ", "qırx ", "əlli ", "altmış ", "yetmiş ", "səksən ", "doğsan " };
        private static string hundred = "yüz ";
        private static string thousand = "min ";

        private static byte GetLength(int a)
        {
            byte length = 0;
            while (a > 0)
            {
                a = a / 10;
                length++;
            }
            return length;
        }

        private static string GetWordByPosition(int a, Digit position)
        {
            if (a == 0) return "";
            if (position == Digit.SINGLE_DIGIT)
                return _singleDigit[a - 1];
            else if (position == Digit.DOUBLE_DIGIT)
                return _doubleDigit[a - 1];
            else if (position == Digit.THREE_DIGIT)
                return string.Concat(_singleDigit[a - 1], hundred);
            else if (position == Digit.FOUR_DIGIT)
                return string.Concat(_singleDigit[a - 1], thousand);
            else if (position == Digit.FIVE_DIGIT)
                return string.Concat(_doubleDigit[a - 1], thousand);

            return "";
        }

        public static string ConvertToWord(int a)
        {
            byte _firstDigit;
            byte _secondDigit;
            byte _lastDigit;
            string _firstWord;
            string _secondWord;
            string _lastWord;


            if (a == 0)
                return "sıfır";

            byte _length = GetLength(a);

            if (_length == (byte)Digit.SINGLE_DIGIT)
                return GetWordByPosition(a, Digit.SINGLE_DIGIT);
            else if (_length == (byte)Digit.DOUBLE_DIGIT)
            {
                _firstDigit = (byte)(a / 10);
                _lastDigit = (byte)(a % 10);

                _firstWord = GetWordByPosition(_firstDigit, Digit.DOUBLE_DIGIT);
                _lastWord = GetWordByPosition(_lastDigit, Digit.SINGLE_DIGIT);

                return string.Concat(_firstWord, _lastWord);
            }
            else if (_length == (byte)Digit.THREE_DIGIT)
            {
                _firstDigit = (byte)(a / 100);
                _secondDigit = (byte)((a % 100) / 10);
                _lastDigit = (byte)((a % 100) % 10);

                _firstWord = GetWordByPosition(_firstDigit, Digit.THREE_DIGIT);
                _secondWord = GetWordByPosition(_secondDigit, Digit.DOUBLE_DIGIT);
                _lastWord = GetWordByPosition(_lastDigit, Digit.SINGLE_DIGIT);

                if (_firstDigit == 1) _firstWord = hundred;

                return string.Concat(_firstWord, _secondWord, _lastWord);
            }

            return "";
        }

    }

    public enum Digit
    {
        SINGLE_DIGIT = 1,
        DOUBLE_DIGIT,
        THREE_DIGIT,
        FOUR_DIGIT,
        FIVE_DIGIT,
        SIX_DIGIT,
        SEVEN_DIGIT,
        EIGHT_DIGIT,
    }
}
