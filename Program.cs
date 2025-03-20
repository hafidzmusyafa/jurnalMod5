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

public class main
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();

        dataBase.AddNewData(10);
        dataBase.AddNewData(30);
        dataBase.AddNewData(22);

        dataBase.PrintAllData();
    }
}