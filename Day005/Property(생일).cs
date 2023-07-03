using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PropoterAPP003
{
    class birthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            birthdayInfo birth = new birthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 06, 28);
            Console.WriteLine($"name : {birth.Name}, birthday ;{birth.Birthday.ToShortDateString()} age : {birth.Age}");
        }
    }
}
