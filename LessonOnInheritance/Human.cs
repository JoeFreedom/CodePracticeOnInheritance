using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    public enum SexType { Male, Female, Dinosaur, Dragon }
    public abstract class Human      // class that can't be realised in the programme directly
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public SexType Sex { set; get;}

       // public virtual void SetAge() { }
    }
}

