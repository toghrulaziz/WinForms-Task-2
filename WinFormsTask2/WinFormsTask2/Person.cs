using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTask2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime DT { get; set; }
        public string Gender { get; set; }

        public Person(string name,string surname,string fathername,string country,string city,string phone,DateTime datetime)
        {
            Name = name;
            Surname = surname;
            FatherName = fathername;
            Country = country;
            City = city;
            Phone = phone;
            DT = datetime;
        }

        public Person(){}

        public override string ToString()
        {
            return $"Name: {Name} \nSurname: {Surname} \nFather Name: {FatherName} \nCountry: {Country} \nCity: {City} \nPhone: {Phone}";
        }

    }
}
