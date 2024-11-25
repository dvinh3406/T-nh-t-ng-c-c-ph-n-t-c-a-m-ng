using System;

namespace dotnet_array_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 7;
            numbers[3] = 4;
            numbers[4] = 2;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}