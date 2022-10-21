using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ut ett tal: "); string inputString = Console.ReadLine();

            Console.WriteLine();

            char[] inputArray = inputString.ToCharArray();

            int[] outputArray = Array.ConvertAll(inputArray, c => (int)Char.GetNumericValue(c));

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (outputArray[i] < 9)
                {
                    outputArray[i]++;
                }
                else if (outputArray[i] == 9)
                {
                    outputArray[i] = 0;
                }

                Console.Write(outputArray[i]);
            }
        }
    }
}
