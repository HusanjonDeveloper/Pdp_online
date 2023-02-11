// num1 va num2 butun sonlari berilgan, num1 dan num2 gacha bo'lgan sonlar
// yig'indisini topuvchi dastur tuzing. num2 > num1, (num1, num2)
// Kiritish:
// num1: 2 ;
// num2: 4 ;
// chiqish: 6 ;

internal class Programm
{
    private static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("birinchi sonni kiritng: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ikkinchi sonni kiriting: ");
        int num2 = int.Parse(Console.ReadLine());

        for (num1 = 1; num1 <= num2; num1++)
        {
            sum += num1;
        }
        System.Console.WriteLine(sum);

    }
}