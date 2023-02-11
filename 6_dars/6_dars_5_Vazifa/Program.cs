// 5-vazifa
// Raqamlari takrorlanmaydigan barcha 3 xonali sonlarni ekranga chiqazuvchi dastur tuzing.
using System;
using System.Collections;
class vazifa5
{
    static void f3D(int[] d, ArrayList r)
    {
        int[] c = new int[10]; ;
        for (int i = 0; i < d.Length; i++)
            c[d[i]]++;
        for (int num = 100; num < 999; num++)
        {
            int[] cC = new int[10];
            int t = num;

            while (t > 0)
            {
                cC[t % 10]++;
                t /= 10;
            }
            bool flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (cC[i] > c[i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                r.Add(num);
            }
        }
    }
    static void pA(ArrayList r, int count)
    {

        for (int i = 0; i < r.Count; i++)
        {
            Console.Write(r[i] + " ");
            count++;
        }
        Console.WriteLine("elemtlar soni:" + count);

    }
    public static void Main(String[] args)
    {
        int[] arr = { 2, 1, 3, 0, 6, 5, 7, 8, 9 };
        ArrayList an = new ArrayList();
        int count = 0;
        f3D(arr, an);
        pA(an, count);
    }
}