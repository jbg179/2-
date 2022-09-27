using System;
class IntegerContantApp
{
    public static void Main()
    {
        int i= 255,h = 0xff;
        long l = 0xffL;
        Console.WriteLine("i={0}, h= {1}", i, h);
        if (h == l) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}