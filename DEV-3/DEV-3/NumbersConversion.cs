using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Conversion a number to the selected number system
    /// </summary>
    class NumbersConversion
    {
        int decimalNumber;
        int scaleOfNotation;
        
        public NumbersConversion (int arg1, int arg2)
        {
            decimalNumber = arg1;
            scaleOfNotation = arg2;
        }

        /// <summary>
        /// Conversion a number to the selected number system
        /// </summary>
        /// <returns> Converted number</returns>
        public List<int> ConversionToRadix()
        {
            List<int> convertedNumber = new List<int>();
            while (decimalNumber > 0)
            {
                if (decimalNumber % scaleOfNotation <= 9)
                {
                    convertedNumber.Insert(0, decimalNumber % scaleOfNotation);
                }
                else
                {
                    convertedNumber.Insert(0, (char)(65 + decimalNumber % scaleOfNotation - 10));
                }
                decimalNumber /= scaleOfNotation;
            }
            return convertedNumber;
        }
    }
}
