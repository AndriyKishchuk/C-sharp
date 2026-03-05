using System;
using System.Collections;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        TestArrayList();
        Console.WriteLine();
        TestList();
    }
    static void TestArrayList()
    {
        ArrayList arraylist = new ArrayList();
        long memoryBefore = GC.GetTotalMemory(true);
        Stopwatch watch = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            arraylist.Add(i);
        }
        watch.Stop();
        long memoryAfter = GC.GetTotalMemory(true);
        Console.WriteLine($"ArrayList: Time taken = {watch.ElapsedMilliseconds} ms, Memory used = {memoryAfter - memoryBefore} bytes");
    }
    static void TestList()
    {
        List<int> list = new List<int>();
        long memoryBefore = GC.GetTotalMemory(true);
        Stopwatch watch = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            list.Add(i);
        }
        watch.Stop();
        long memoryAfter = GC.GetTotalMemory(true);
        Console.WriteLine($"List: Time taken = {watch.ElapsedMilliseconds} ms, Memory used = {memoryAfter - memoryBefore} bytes");
    }
}