using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW_ACO_TSP
{
    public partial class Form1 : Form
    {
        public double[,] Cost;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadData_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse";
            openFileDialog1.Filter = "flow Data (*.mbs) | *.mbs";

            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            string sFilePath = openFileDialog1.FileName;
            if (sFilePath == "") return;

            LoadData(sFilePath);

            //초기화
            Run_Button.Enabled = true;

            txtResult_Best.Text = "";
            txtResult_Best_Cost.Text = "";
        }

        private void LoadData(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);

            Cost = new double[17, 17];

            string imLine;
            string[] words;

            for (int j = 0; j < 17; j++)
            {
                imLine = sr.ReadLine();
                words = imLine.Split(' ');

                for (int k = 0; k < 17; k++)
                {
                    Cost[j, k] = Convert.ToInt32(words[k]);                  
                }
            }

        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            ACO aco = new ACO();

            aco.nAnt = Convert.ToInt32(txtnAnt.Text);
            aco.Alpha = Convert.ToDouble(txtAlpha.Text);
            aco.Beta = Convert.ToDouble(txtBeta.Text);
            //aco.Initial_Pheromone = Convert.ToDouble(txtInitial_Pheromone.Text);
            aco.Decay = Convert.ToDouble(txtDecay.Text);
            aco.Pheromone_Evaporation = Convert.ToDouble(txtPheromone_Evaporation.Text);

            aco.Cost = Cost;

            aco.Run_ACO();

            txtResult_Best.Text = "";

            for (int j = 0; j < 17; j++)
            {
                txtResult_Best.Text += Convert.ToString(aco.Best_Solution[j] + 1) + " ";
            }
            txtResult_Best_Cost.Text = Convert.ToString(aco.Best);
        }

        private void txtInitial_Pheromone_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
