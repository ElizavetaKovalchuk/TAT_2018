﻿using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// Serch elements with odd index in a string and create string
    /// </summary>
    class Creator
    {
        public string sequnceOfSymbol;
        public Creator(string sequnceOfSymbol)
        {
            sequnceOfSymbol = enteredSequence;
        }
        
        /// <summary>
        /// Serch elements with odd index in a string and create string
        /// </summary>
        /// <returns> string of elements with odd indeks</returns>
        public string CreateSequenceOfOddSymbol()
        {
            StringBuilder oddElements = new StringBuilder();
            for (int i = 0; i < sequnceOfSymbol.Length; i += 2)
            {
                oddElements.Append(sequnceOfSymbol[i]);
            }
            return oddElements.ToString();
        }
    }
}
