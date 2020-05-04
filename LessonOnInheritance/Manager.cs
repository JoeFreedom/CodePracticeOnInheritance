using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class Manager : Human
    {
        public string Position { set; get; }
        public int Salary { set; get; }

        public Manager() { }
        public Manager(string name, int age, SexType sex, string position, int salary) 
        {
            Name = name;
            Age = age;
            Sex = sex;
            Position = position;
            Salary = salary;
        }

       // public override void SetAge() { }

    }
}
