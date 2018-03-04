using System;
using System.Text;
namespace DEV_2
{
    class SerchOddElements
    {
        public string enteredString;
        public SerchOddElements(string enteredSymbol)
        {
            enteredString = enteredSymbol;
        }
        /// <summary>
        /// Serch elements with odd ideks in a string
        /// </summary>
        /// <returns> string of elements with odd indeks</returns>
        public string SerchOddSymbol()
        {
            StringBuilder oddElements = new StringBuilder(enteredString);
            for (int i = 1; i < oddElements.Length; i++)
            {
                oddElements = oddElements.Remove(i,1);
            }
            string newString = oddElements.ToString();
            return newString;
        }
    }
}
