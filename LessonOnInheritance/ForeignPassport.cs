using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    public enum VisaType { SingleEntry, MultipleEntry, BusinesVisa, TouristVisa }
    public enum PagesNumber { ThirtyTwo, SixtyFour}
    class ForeignPassport : Passport
    {
        public PagesNumber PagesNum { set; get; }
        public VisaType Visa { set; get; }
        public string CountriesBeenTo { set; get; }
        public string PassportSeries { set; get; }

        public ForeignPassport() { }
        public ForeignPassport(string nationality, string firstName, string lastName, DateTime dateOfBirth, SexxType sexx, string placeOfBirth, string issuingAuthority,
                                string passportNumber, DateTime whenissued, DateTime whenToExpire, PagesNumber pagesNum, VisaType visa, string countriesBeenTo, 
                                string passportSeries)
        {
            Nationality = nationality;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Sexx = sexx;
            PlaceOfBirth = placeOfBirth;
            IssuingAuthority = issuingAuthority;
            PassportNumber = passportNumber;
            WhenIssued = whenissued;
            WhenToExpire = whenToExpire;
            PagesNum = pagesNum;
            Visa = visa;
            CountriesBeenTo = countriesBeenTo;
            PassportSeries = passportSeries;

        }
    }
}
