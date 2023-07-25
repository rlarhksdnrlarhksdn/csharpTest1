using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz001
{
    internal class Program
    {
        class Student
        {
            public int STID { get; set; }

            public string Name { get; set; }

            public string Major { get; set; }
        }
        static void Main(string[] args)
        {
            string path = "student.json";
            using (Stream ws = new FileStream(path, FileMode.Create))
            {
                Student student = new Student();
                student.STID = 12345;
                student.Name = "이순신";
                student.Major = "스마트 팩토리";

                string jsonString = JsonSerializer.Serialize<Student>(student);
                byte[] bytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(bytes, 0, bytes.Length);
            }
            using (Stream rs = new FileStream(path, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = System.Text.Encoding.UTF8.GetString(jsonBytes);

                Student student2 = JsonSerializer.Deserialize<Student>(jsonString);

                Console.WriteLine(student2.STID);
                Console.WriteLine(student2.Name);
                Console.WriteLine(student2.Major);
            }


        }
    }
}
