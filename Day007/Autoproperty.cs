using System;

namespace AutoProperty001
{
    //P346
    internal class Program
    {
        class BirthdatInfo
        {
            public string Name { get; set; } = "Unknown";
            public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
            public int Age
            {
                get
                {
                    return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
                }
            }
        }
        static void Main(string[] args)
        {
            BirthdatInfo birth = new BirthdatInfo();
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Age);
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
