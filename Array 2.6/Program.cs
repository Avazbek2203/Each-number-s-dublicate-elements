using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("Enter length of pattern : ");
        int input = int.Parse(Console.ReadLine());
        int[] arr = new int[input];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 10);
            Console.Write(arr[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            Console.WriteLine($" {arr[i]} - {count} times");
        }
    }
}
