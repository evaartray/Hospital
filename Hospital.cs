using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Hospital
    {
        private string name { get; set; }

        public Hospital(string newName)
        {
            this.name = newName;
        }

        List<Worker> workersList = new List<Worker>();

        public void AddWorker(Worker worker)
        {
            workersList.Add(worker);
        }

        public virtual void DisplayInfo()
        {
            Console.Clear();
            foreach (Worker w in workersList)
            {
                w.Info();
                Console.WriteLine("Welcome to hospital, " + this.name);
            }
        }
    }
}
