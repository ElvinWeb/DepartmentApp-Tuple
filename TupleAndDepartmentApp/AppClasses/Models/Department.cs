using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppClasses.Models
{
    public class Department
    {

        public Worker[] workers = Array.Empty<Worker>();
        public string Name { get; set; }

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers, workers.Length + 1);
            workers[^1] = worker;
        }
        public void AddWorker(ref Worker[] array, Worker worker)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = worker;
        }

        public Worker[] SearchWorker(string name)
        {
            Worker[] searchedWorkers = Array.Empty<Worker>();

            foreach (Worker worker in workers)
            {
                if (worker.Name.ToLower() == name.ToLower())
                {
                    AddWorker(ref searchedWorkers, worker);
                }
            }

            ShowAllWorkers(searchedWorkers);

            return searchedWorkers;
        }
        public Worker[] SearchWorker(double minExperience, double maxExperience)
        {
            Worker[] searchedWorkers = Array.Empty<Worker>();
            foreach (Worker worker in workers)
            {
                if (minExperience <= worker.Experience && maxExperience >= worker.Experience)
                {
                    AddWorker(ref searchedWorkers, worker);
                }
            }
            ShowAllWorkers(searchedWorkers);

            return searchedWorkers;
        }


        public void ShowAllWorkers(Worker[] workersArr)
        {
            foreach (Worker worker in workersArr)
            {
                Console.WriteLine($"Adi:{worker.Name} , Soyadi:{worker.Surname} , Kodu:{worker.WorkerCode} , Tecrubesi:{worker.Experience}");
            }
        }
        public void ShowAllWorkers()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"Adi:{worker.Name} , Soyadi:{worker.Surname} , Kodu:{worker.WorkerCode} , Tecrubesi:{worker.Experience}");
            }
        }

    }
}
