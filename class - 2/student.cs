using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___2
{
    class student
    {
        private String fullName;

        public String FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private int ID;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        private int Average;

        public int average
        {
            get { return Average; }
            set { Average = value; }
        }

        public student(string fullname, int id, int average)
        {
            this.fullName = fullname;
            this.id = id;
            this.average = average;
        }
        public void calculateaverage()
        {
            int a, b, c, d, e;
            //for (int i = 0; i > 4; i++)
            //    Console.WriteLine("please enter student's name");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("please enter the student's ID");
            //int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 5 grades of the student's");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            average = (a + b + c + d + e) / 5;
        }

    }
}
