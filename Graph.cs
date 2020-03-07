using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Msagl = Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Corruption
{
    class Graph
    {
        public Dictionary<string, City> cities;
        public string startCity;
        public List<Edge> infectedEdge;

        public Graph()
        {
            this.cities = new Dictionary<string, City>();
            this.infectedEdge = new List<Edge>();
        }

        public void BFS(int time)
        {
            this.cities[this.startCity].timeInfected = 0;

            Queue<Edge> VirusInfector = new Queue<Edge>();

            foreach (City c in this.cities[startCity].neighbors.Keys)
            {
                VirusInfector.Enqueue(new Edge(this.cities[startCity], this.cities[c.name]));
            }

            City currentCity;
            City targetCity;
            Edge cityTuple;
            int t;
            int timeInfectedTemp;

            while (VirusInfector.Count > 0)
            {
                cityTuple = VirusInfector.Dequeue();
                currentCity = cityTuple.fromCity;
                targetCity = cityTuple.toCity;

                if (currentCity.CanInfect(targetCity, time))
                {
                    t = currentCity.GetDayTargetInfected(targetCity);
                    timeInfectedTemp = currentCity.timeInfected + t;
                    if (timeInfectedTemp < targetCity.timeInfected)
                    {
                        foreach (City c in this.cities[targetCity.name].neighbors.Keys)
                        {
                            VirusInfector.Enqueue(new Edge(this.cities[targetCity.name], this.cities[c.name]));
                        }
                        targetCity.timeInfected = timeInfectedTemp;
                        targetCity.isInfected = true;
                    }
                    infectedEdge.Add(cityTuple); //tambahin edge yang merupakan edge virus
                }
            }
        }
        public void animate(int T)
        {
            int t = 0;
            while (t < T)
            {
                this.spread(t);
                t++;
                // g.Visualize();
                if (t % 10 == 0)
                {
                    Console.WriteLine("Day " + t);
                    this.PrintInfo(t);
                    Console.WriteLine();
                }
            }
        }

        private void spread(int t)
        {
            this.cities[this.startCity].timeInfected = 0;
            this.cities[this.startCity].isInfected = true;
            Queue<City> infected = new Queue<City>();

            foreach (City c in this.cities.Values)
            {
                if (c.isInfected)
                {
                    infected.Enqueue(c);
                }
                c.isInfected = false;
            }

            while (infected.Count > 0)
            {
                City inf = infected.Dequeue();
                inf.isInfected = true;
                foreach (City c in inf.neighbors.Keys)
                {
                    if (inf.CanInfect(c, t) && !c.isInfected)
                    {
                        c.isInfected = true;
                        c.timeInfected = Math.Min(t, c.timeInfected);
                        infected.Enqueue(this.cities[c.name]);
                    }
                }
            }
        }

        public void Visualize()
        {
            //create a form 
            Form form = new Form();

            //create a viewer object 
            GViewer viewer = new GViewer();

            //create a graph object 
            Msagl.Graph graph = new Msagl.Graph("Corruption");

            //create the graph content
            foreach (City city in this.cities.Values)
            {
                graph.AddNode(city.name);
                if (city.isInfected)
                {
                    graph.FindNode(city.name).Attr.FillColor = Msagl.Color.OrangeRed;
                }

                foreach (City neigh in city.neighbors.Keys)
                {
                    bool tmp = false;
                    foreach (Edge e in this.infectedEdge)
                    {
                        if ((e.fromCity == city && e.toCity == neigh))
                        {
                            tmp = true;
                        }
                    }
                    if (!tmp)
                    {
                        graph.AddEdge(city.name, neigh.name).Attr.Color = Msagl.Color.Gray;
                    }
                }
            }
            foreach (Edge e in this.infectedEdge)
            {
                graph.AddEdge(e.fromCity.name, e.toCity.name).Attr.Color = Msagl.Color.Red;
            }
            //graph.AddEdge("A", "C").Attr.Color = Msagl.Color.Green;
            //graph.FindNode("A").Attr.FillColor = Msagl.Color.Magenta;
            //graph.FindNode("B").Attr.FillColor = Msagl.Color.MistyRose;
            //Msagl.Node c = graph.FindNode("C");
            //c.Attr.FillColor = Msagl.Color.PaleGreen;
            //c.Attr.Shape = Msagl.Shape.Diamond;

            //bind the graph to the viewer 
            viewer.Graph = graph;

            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();

            //show the form 
            form.ShowDialog();
        }

        public void PrintInfectionPath()
        {
            Console.WriteLine("Virus Path:");
            int count = 0;
            foreach (Edge cityEdge in this.infectedEdge)
            {
                count++;
                Console.Write(count + ". ");
                cityEdge.printInfoEdge();
            }
            Console.WriteLine();
        }

        public void PrintInfo()
        {
            foreach (City city in this.cities.Values)
            {
                city.PrintInfo();
            }
        }

        public void PrintInfo(int t)
        {
            foreach (City city in this.cities.Values)
            {
                city.PrintInfo(t);
            }
        }

        public void loadFromFile(string population, string peta)
        {
            this.loadPopulationFromFile(population);
            this.loadPetaFromFile(peta);
        }

        private void loadPetaFromFile(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
            {
                string str = sr.ReadLine();
                while ((str = sr.ReadLine()) != null)
                {
                    string[] tmp = str.Split(' ');
                    this.cities[tmp[0]].SetConnectionRate(this.cities[tmp[1]], Double.Parse(tmp[2], System.Globalization.CultureInfo.InvariantCulture));
                }
            }
        }

        private void loadPopulationFromFile(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
            {
                string line = sr.ReadLine();
                string[] tmp = line.Split();
                int numCity = Int32.Parse(tmp[0]);
                this.startCity = tmp[1];

                while ((line = sr.ReadLine()) != null)
                {
                    tmp = line.Split(' ');
                    this.cities.Add(tmp[0], new City(tmp[0], Int32.Parse(tmp[1])));
                }
            }
        }
    }
}
