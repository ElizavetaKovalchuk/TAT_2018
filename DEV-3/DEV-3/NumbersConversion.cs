using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Conversion a number to the selected number system
    /// </summary>
    class NumbersConversion
    {
        int number;
        int scaleOfNotation;
        public NumbersConversion (int arg0, int arg1)
        {
            number = arg0;
            scaleOfNotation = arg1;
        }

        /// <summary>
        /// Conversion a number to the selected number system
        /// </summary>
        /// <returns> Converted number</returns>
        public List<int> ConversionToRadix()
        {
            List<int> convertedNumber = new List<int>();
            int result = 0;
            while (number > 0)
            {
                result = number % scaleOfNotation;
                if (result <= 9)
                {
                    convertedNumber.Insert(0, result);
                }
                else
                {
                    char scale = (char)(65 + result - 10);
                    convertedNumber.Insert(0, scale);
                }
                number /= scaleOfNotation;
            }
            return convertedNumber;
        }
    }
}
