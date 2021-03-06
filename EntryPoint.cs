﻿using System;
using System.Text;

namespace DEV_2
{
    class EntryPoint
    {
        /// <summary>
        /// It is an entry point of the program and it is outputs elements with odd index
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string line = Console.ReadLine();
            if (line.Length == 0)
            {
                Console.WriteLine("String is empty");
            }
            else
            {
                Creator enteredSequence = new Creator(line);
                Console.WriteLine(enteredSequence.CreateSequenceOfOddSymbol());
            }
        }
    }
}
