using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corruption
{
    class City
    {
        public string name { get; set; }
        public int population { get; set; }
        public Dictionary<City, double> neighbors { get; set; }
        public int timeInfected { get; set; }
        public bool isInfected { get; set; }

        public City(string _name, int _population)
        {
            this.name = _name;
            this.population = _population;

            this.timeInfected = Int32.MaxValue; // initial value
            this.neighbors = new Dictionary<City, double>();
        }

        public void SetConnectionRate(City b, double w)
        {
            this.neighbors[b] = w;
        }

        /* Adding neighbor country methods */
        public void AddNeighbor(City neighbor, double weight)
        {
            this.neighbors.Add(neighbor, weight);
        }

        /*
        @param : t = Current Time from main program
        */
        private double InfectedPopulation(double t)
        {
            return (this.population / (1 + (this.population - 1) * Math.Exp(-0.25 * (t - this.timeInfected))));
        }

        /*
          Prekondisi : Validasi terhadap infeksi dalam selang waktu t terhadap
                       kota lain pasti terjadi 
        */
        public int GetDayTargetInfected(City toCity)
        {
            int time = this.timeInfected;
            while (!this.CanInfect(toCity, time))
            {
                time++;
            }
            return (time - this.timeInfected);
        }

        /*
        @param : City toCity wanna be infected city
        @param : t : Current Time (from main program)
        S
        */
        public bool CanInfect(City toCity, double t)
        {
            return this.InfectedPopulation(t) * this.neighbors[toCity] > 1;
        }

        public bool CanInfect(City toCity, int t)
        {
            return this.CanInfect(toCity, (double)t);
        }

        private void PrintInfoUtil()
        {
            Console.WriteLine("==== City " + this.name + " ====");
            Console.WriteLine("Population: " + this.population.ToString());
            Console.WriteLine("Connected Cities:");
            foreach (KeyValuePair<City, double> c in this.neighbors)
            {
                Console.WriteLine(c.Key.name + " (transfer rate): " + c.Value.ToString());
            }
            Console.Write("Infected on day: ");
            if (this.timeInfected == Int32.MaxValue)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(this.timeInfected.ToString());
            }
        }

        public void PrintInfo()
        {
            this.PrintInfoUtil();
            Console.WriteLine();
        }

        public void PrintInfo(int t)
        {
            this.PrintInfoUtil();
            int infPop = (int)Math.Ceiling(this.InfectedPopulation(t));
            Console.WriteLine("Infected Population: " + infPop + " (" + (double)infPop / this.population * 100 + "%)");
            Console.WriteLine();
        }
    }
}
