using System;

namespace _12Pamoka_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Iveskite 3 skaicius: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int userInput3 = Convert.ToInt32(Console.ReadLine());

            int[] arrayGroup = { userInput1, userInput2, userInput3 };
            int[] result = PakeltaKvadratu(arrayGroup);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);

        }
        public static int[] PakeltaKvadratu(int[] arrayGroup)
        {
            int[] result = new int[arrayGroup.Length];
            result[0] = arrayGroup[0] * arrayGroup[0];
            result[1] = arrayGroup[1] * arrayGroup[1];
            result[2] = arrayGroup[2] * arrayGroup[2];
            return result;

        }
    }
}