using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntColonySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string fileName = "ACO-Matrix.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"", fileName);

            //List<Point> points = TspFileReader.ReadTspFile(filePath);    // Parse TSPlib file and load as List<Point>
            List<Point> points = AcoFileReader.ReadACOFile(filePath);
            int[][] distanceMatrix = AcoFileReader.GetDistanceMatrix();

            Graph graph = new Graph(points, true, distanceMatrix);  // Create Graph
            GreedyAlgorithm greedyAlgorithm = new GreedyAlgorithm(graph);
            double greedyShortestTourDistance = greedyAlgorithm.Run();  // get shortest tour using greedy algorithm

            Parameters parameters = new Parameters()  // Most parameters will be default. We only have to set T0 (initial pheromone level)
            {
                T0 = (1.0 / (graph.Dimensions * greedyShortestTourDistance))
            };
            parameters.Show();

            Solver solver = new Solver(parameters, graph);
            List<double> results = solver.RunACS(); // Run ACS

            Console.WriteLine("Time: " + solver.GetExecutionTime());
            Console.ReadLine();
        }

    }
}