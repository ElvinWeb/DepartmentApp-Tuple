using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClasses.Models
{
    public class Worker : Department
    {
        private double _experience;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WorkerCode { get; set; }
        public double Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0)
                {
                    this._experience = value;
                }
                else
                {
                    Console.WriteLine("Tecrube menfi ve ya sifir ola bilmez");
                }
                

            }
        }

        public Worker(string name, string surname, double experience)
        {
            this.Name = name;
            this.Surname = surname;
            this.WorkerCode = char.ToUpper(name[0]) + "" + char.ToUpper(surname[0]);
            this.Experience = experience;
        }
    }
}
