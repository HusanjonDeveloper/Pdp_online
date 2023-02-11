// 10-vazifa
// N sonini M soniga bo'lgandagi qoldiqni, / va % operatorlarini ishlatmasdan topuvchi dastur tuzing. 

using System;
class pdp_online
{
    static int gt(int num, int d)
    {
        return (num - d * (num / d));
    }
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine(gt(n, m));
    }
}