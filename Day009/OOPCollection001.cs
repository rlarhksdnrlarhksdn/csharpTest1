using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCollection001
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string phonenumber { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person jane = new Person("제인");
            Person Tom = new Person("톰");
            Person Bob = new Person("밥");

            List<Person> list = new List<Person>();
            list.Add(jane);
            list.Add(Tom);
            list.Add(Bob);

            //제거
            list.Remove(Tom);
            //추가?
            Person Sam = new Person("샘");
            list.Add(Sam);

            // 정렬해서 출력??
            //List<int> list2 = new List<int>() { 9, 8, 6, 5 };
            //list2.Sort();

            //list.Sort();

            list.Sort((a, b) => a.Name.CompareTo(b.Name));

            foreach (Person p in list)
            {
                Console.WriteLine(p.Name);
            }

        }
    }
}
