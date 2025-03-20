using System;

public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T x, T y, T z)
    {
        dynamic X = x;
        dynamic Y = y;
        dynamic Z = z;

        if(X > Y && X > Z)
        {
            Console.WriteLine("maximum: " + X);
        } 
        else if(Y > Z && Y > X)
        {
            Console.WriteLine("maximum: " + Y);
        }
        else if(Z > X && Z > Y)
        {
            Console.WriteLine("maximum: " + Z);
        }
    }
}

public class main
{
    public static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();

        float x = 10;
        float y = 30;
        float z = 22;

        Console.WriteLine($"{x} {y} {z}");
        data.DapatkanNilaiTerbesar(x, y, z);
    }
}