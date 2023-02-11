// n butun soni berilgan, 1 dan n sonigacha bo'lgan
// tub sonlarni ekranda chiqaruvchi dastur tuzing. n > 1
// Kiritish: 5
// Chiqish: 2 3

int num, i, ctr, stno, enno;

Console.Write("\n\n");
Console.Write("Raqamlar diapazonidagi tub sonlarni toping:\n");
Console.Write("---------------------------------------------------");
Console.Write("\n\n");

Console.Write("Diapazonning boshlang'ich raqamini kiriting: ");
stno = Convert.ToInt32(Console.ReadLine());
Console.Write("Diapazonning yakuniy sonini kiriting: ");
enno = Convert.ToInt32(Console.ReadLine());
Console.Write("{0} va {1} orasidagi tub sonlar: \n", stno, enno);

for (num = stno; num <= enno; num++)
{
    ctr = 0;

    for (i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            ctr++;
            break;
        }
    }

    if (ctr == 0 && num != 1)
        Console.Write("{0} ", num);
}
Console.Write("\n");

