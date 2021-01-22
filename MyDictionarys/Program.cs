using System;

namespace MyDictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> School = new MyDictionary<int, string>();

            School.Add(1, "Süleyman Demirel Üniversitesi");
            School.Add(2, "Akdeniz Üniversitesi");
            School.Add(3, "Ankara Üniversitesi");
            Console.WriteLine(School.Count);
        }
    }
}
