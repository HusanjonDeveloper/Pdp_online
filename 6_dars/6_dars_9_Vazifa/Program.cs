// 9-vazifa
// 30 - 100 oraliqdagi 3 ga karrali va oxirgi raqami 2,4,8 bo’lgan sonlarni ekranga chiqazing.

for (int i = 30; i < 100; i++)
{
    if (i % 3 == 0)
    {
        if (i % 10 == 2)
            Console.WriteLine(i);
        if (i % 10 == 4)
            Console.WriteLine(i);
        if (i % 10 == 8)
            Console.WriteLine(i);
    }
}