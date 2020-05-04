using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class Student_PhD : Human
    {
        public string Discipline { set; get; }
        public string Faculty { set; get; }
        public string Theme { set; get; }

        public Student_PhD() { }
        public Student_PhD (string discipline, string faculty, string theme, SexType sex, string name, int age)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Discipline = discipline;
            Faculty = faculty;
            Theme = theme;
        }
    }
}
