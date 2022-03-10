using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___2
{
    class Program
    {
        static void Main(string[] args)
        {
            student my_student1 = new student("eldor", 555, 0);
            my_student1.calculateaverage();
            Console.WriteLine("your avearge is :{0}", my_student1.average);

            student my_student2 = new student("eldor", 555, 0);
            my_student2.calculateaverage();
            Console.WriteLine("your avearge is :{0}", my_student2.average);

            student my_student3 = new student("eldor", 555, 0);
            my_student3.calculateaverage();
            Console.WriteLine("your avearge is :{0}", my_student3.average);

        }
    }
}
