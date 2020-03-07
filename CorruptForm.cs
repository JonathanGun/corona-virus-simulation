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
        string filePetaPath = "";
        string filePopulationPath = "";

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
            Graph g = new Graph();
            g.loadFromFile(population: this.filePopulationPath, peta: this.filePetaPath);
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

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            signPeta.Text = "-";
            popLabel.Text = "-";

            filePetaPath = "";
            filePopulationPath = "";

            numPicker.Value = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.filePetaPath = fileDialog.FileName;
                signPeta.Text = "OK";
                Console.WriteLine("File Peta: " + this.filePetaPath);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void popBtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.filePopulationPath = fileDialog.FileName;
                popLabel.Text = "OK";
                Console.WriteLine("File Populasi : " + this.filePopulationPath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
