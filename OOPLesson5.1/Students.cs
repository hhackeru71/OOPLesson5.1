using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson5._1
{
    internal class Students : Person
    {
        public int Grades { get; set; }

        public Students(int grades, string firstName, string lastName)
            :base(firstName, lastName)
        {
            Grades = grades;
        }

        public override string GetString()
        {
            return base.GetString()+ " "+ Grades;
        }
    }
}
