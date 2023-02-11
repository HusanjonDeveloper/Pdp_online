// 6-vazifa

// Raqamlar yig’indisi 15ga teng bo’lgan 100-500 oraliqdagi sonlarni ekranga chiqazuvchi dastur tuzing.


using System;

class vazifa5
{
    public static void Main(String[] args)
    {
        int sum = 0;
        for (int n = 100; n < 500; n++)
        {
            sum = n % 10 + (n / 10) % 10 + (n / 100);
            if (sum == 15)
            {
                Console.WriteLine(n);
            }
        }

    }
}