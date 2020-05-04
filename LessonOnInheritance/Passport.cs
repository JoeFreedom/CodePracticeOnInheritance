using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
   
    public enum SexxType { Male, Female, Dragon, Dinosaur}
    public class Passport
    { 
        public string Nationality { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public SexxType Sexx { set; get; }
        public string PlaceOfBirth { set; get; }
        public string IssuingAuthority { set; get; }
        public string PassportNumber { set; get; }
        public DateTime WhenIssued { set; get; }
        public DateTime WhenToExpire { set; get; }
        
    }
}
