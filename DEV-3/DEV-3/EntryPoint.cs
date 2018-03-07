using System;
using System.Collections.Generic;


namespace DEV_3
{
    /// <summary>
    /// It is entry point of the program and it is print a number in the selected number system
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int arg1 = Int32.Parse(args[0]);
            int arg2 = Int32.Parse(args[1]);
            if (arg2 >= 2 && arg2 <= 20)
            {
                NumbersConversion enteredValues = new NumbersConversion(arg1, arg2);
                foreach (var convertedNumber in enteredValues.ConversionToRadix())
                {
                    Console.WriteLine(convertedNumber);
                }
            }
        }
    }
}
