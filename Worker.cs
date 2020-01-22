using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Worker
    {
        protected string firstName { get; private set; }
        private string lastName { get; set; }

        public Worker(string newFirstName, string newLastName)
        {
            this.firstName = newFirstName;
            this.lastName = newLastName;
        }

        public virtual void Info()
        {
            Console.WriteLine(this.firstName + " " + this.lastName);
        }

    }
}
