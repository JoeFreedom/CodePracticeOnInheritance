using System;

using static System.Console;

namespace LessonOnInheritance
{
    class Program
    {
        static void ShowManager(Manager manager)
        {
            Write($"{manager.Name} \n{manager.Age} \n{manager.Sex} \n{manager.Position} \n{manager.Salary} \n \n");
        }
        static void ShowStudent(Student_PhD studentPhD)
        {
            WriteLine($"{studentPhD.Name} \n{studentPhD.Age} \n{studentPhD.Sex} \n{studentPhD.Discipline} \n{studentPhD.Faculty} \n{studentPhD.Theme} \n \n");
        }
        static void ShowForeignPassport(ForeignPassport foreignPassport)
        {
            Write($"{foreignPassport.Nationality}\n{foreignPassport.LastName}\n{foreignPassport.FirstName}\n{foreignPassport.DateOfBirth}\n{foreignPassport.Sexx}\n{foreignPassport.PlaceOfBirth}\n" +
                $"{foreignPassport.IssuingAuthority}\n{foreignPassport.PassportNumber}\n{foreignPassport.WhenIssued}\n{foreignPassport.WhenToExpire}");
        }

        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Name = "Andrew";
            manager.Age = 34;
            manager.Sex = SexType.Dinosaur;
            manager.Position = "President of Presidents";
            manager.Salary = 2000;
        

            ShowManager(manager);

            Student_PhD studentPhD = new Student_PhD
            {
                Name = "Desmond Jupiter",
                Age = 35,
                Sex = SexType.Dragon,
                Discipline = "World Problem",
                Faculty = "World Diseases",
                Theme = "F**k Coronavirus"

            };
            ShowStudent(studentPhD);

            ForeignPassport foreignPassport = new ForeignPassport();
            foreignPassport.Nationality = "Plutonian";
            foreignPassport.FirstName = "Rex";
            foreignPassport.LastName = "Tyrannosaurus";
            foreignPassport.DateOfBirth = new DateTime(1666, 12, 23);
            foreignPassport.Sexx = SexxType.Dinosaur;
            foreignPassport.PlaceOfBirth = "North Pluto";
            foreignPassport.IssuingAuthority = "Federal Planet of Pluto";
            foreignPassport.PassportNumber = "AAAA0//3045";
            foreignPassport.WhenIssued = new DateTime(1666, 12, 23);
            foreignPassport.WhenToExpire = new DateTime(9999, 12, 31);
            foreignPassport.PagesNum = PagesNumber.SixtyFour;
            foreignPassport.PassportSeries = "VVVV111444VVVV";
            foreignPassport.Visa = VisaType.MultipleEntry;                   
            foreignPassport.CountriesBeenTo = "Japan, Australia, Russia, The USA, Canada, The UK and Antarctica";

            ShowForeignPassport(foreignPassport);


        }
       
        

         
        
    }
}
