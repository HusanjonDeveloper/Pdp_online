// n butun soni berilgan, 1 dan n sonigacha bo'lgan toq
// sonlarni ekranda chiqaruvchi dastur tuzing. n > 1
// Kiritish: 5
// Chiqish: 3


using System;

internal class Programm
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num");
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < num)
            {
                Console.WriteLine(counter);
                counter += 2;
            }
        }
    }
}