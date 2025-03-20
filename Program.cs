using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        foreach (T data in storedData)
        {
            Console.WriteLine($"Data {data} berisi: {data}, yang disimpan pada waktu UTC: {DateTime.Now}\r\n");
        }
    }
}

public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T x, T y, T z)
    {
        dynamic X = x;
        dynamic Y = y;
        dynamic Z = z;

        if (X > Y && X > Z)
        {
            Console.WriteLine("maximum: " + X);
        }
        else if (Y > Z && Y > X)
        {
            Console.WriteLine("maximum: " + Y);
        }
        else if (Z > X && Z > Y)
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

        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();

        dataBase.AddNewData(10);
        dataBase.AddNewData(30);
        dataBase.AddNewData(22);

        dataBase.PrintAllData();
    }
}