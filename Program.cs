using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

       
        int length = (int)Math.Floor(Math.Log10(number)) + 1;

        if (length < 2) {
            Console.WriteLine("нет");
        } else {
            int digit = (int)(number / Math.Pow(10, length - 2)) % 10;
            Console.WriteLine(digit);
        }
    }
}
