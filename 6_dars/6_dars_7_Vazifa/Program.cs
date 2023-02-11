// 7-vazifa
// To’rt xonali sonlar orasidan 47 ga bo’lganda qoldiq
// 43 va 43 ga bo’lganda qoldiq 40 bo’lgan sonlarni topish dasturini tuzing.

for (int i = 1000; i < 10000; i++)
{
    if (i % 47 == 43 && i % 43 == 40)
    {
        Console.WriteLine(i);
    }
}