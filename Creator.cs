using System;
using System.Text;
namespace DEV_2
{
    /// <summary>
    /// Serch elements with odd indeks in a string and create string
    /// </summary>
    class Creator
    {
        public string sequnceOfSymbol;
        public Creator(string sequnceOfSymbol)
        {
            sequnceOfSymbol = enteredSequence;
        }
        /// <summary>
        /// Serch elements with odd indeks in a string and create string
        /// </summary>
        /// <returns> string of elements with odd indeks</returns>
        public string CreateSequenceOfOddSymbol()
        {
            StringBuilder oddElements = new StringBuilder(sequnceOfSymbol);
            for (int i = 1; i < oddElements.Length; i++)
            {
                oddElements = oddElements.Remove(i,1);
            }
            return oddElements.ToString();
        }
    }
}
