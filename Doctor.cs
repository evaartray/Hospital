using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Doctor : Worker
    {
        private string speciality { get; set; }

        public Doctor(string newFirstName, string newLastName, string newSpeciality)
            : base(newFirstName, newLastName)
        {
            this.speciality = newSpeciality;
        }

        public override void Info()
        {
            Console.WriteLine("Speciality: " + this.speciality);
        }

    }
}
