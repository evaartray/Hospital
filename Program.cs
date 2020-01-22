using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of new hospital: ");
            Hospital myHospital = new Hospital(Console.ReadLine());

            Console.WriteLine("Please enter the name of new worker: ");

            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);
            string lastName = Console.ReadLine();
            Console.WriteLine(lastName);

            Worker myWorker = new Worker(firstName, lastName);

            myHospital.AddWorker(myWorker);
            
            firstName = Console.ReadLine();
            Console.WriteLine(firstName);
            lastName = Console.ReadLine();
            Console.WriteLine(lastName);
            string speciality = Console.ReadLine();
            Console.WriteLine(speciality);

            Doctor myDoctor = new Doctor(firstName, lastName, speciality);

            myHospital.AddWorker(myDoctor);

            myHospital.DisplayInfo();
        }


    }
}
