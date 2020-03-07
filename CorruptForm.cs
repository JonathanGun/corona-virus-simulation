using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corruption;

namespace Corruption
{
    public partial class CorruptForm : System.Windows.Forms.Form
    {
        public CorruptForm()
        {
            InitializeComponent();
        }

        private void numPicker_ValueChanged(object sender, EventArgs e)
        {
              // do nothing
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string tcfolder = "testcase/";
            Graph g = new Graph();
            g.loadFromFile(population: tcfolder + "1_population.txt", peta: tcfolder + "1_peta.txt");
            int time = (int) numPicker.Value;
            g.BFS(time);
            g.PrintInfectionPath();
            g.PrintInfo();
            g.Visualize();
            g.animate(time);
        }

        private void labelText_Click(object sender, EventArgs e)
        {
            // do nothing
        }
    }
}
