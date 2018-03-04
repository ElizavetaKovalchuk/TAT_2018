using System;
using System.Text;

namespace DEV_2
{
    class EntryPoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string line = Console.ReadLine();
            StringBuilder sequence = new StringBuilder(line);
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence = sequence.Remove(i,1);
            }
            Console.WriteLine(sequence);
        }
    }
}
