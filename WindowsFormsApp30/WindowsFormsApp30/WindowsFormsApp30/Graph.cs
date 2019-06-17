using System;
using System.Collections.Generic;

namespace AntColonySystem
{
    public class Graph
    {
        public List<Point> Points { get; set; }

        public Dictionary<int, Edge> Edges { get; set; }
        public int Dimensions { get; set; }
        public double MinimumPheromone { get; set; }
        private bool IsSymetric { get; set; }

        public Graph(List<Point> Points, bool isSymetric, int[][] distanceMatrix)
        {
            Edges = new Dictionary<int, Edge>();
            this.Points = Points;
            Dimensions = Points.Count;
            IsSymetric = isSymetric;
            CreateEdges(distanceMatrix);
        }

        /// <summary>
        /// Create edges between all points. 
        /// NOTE: For every two points there is two edges between them in case of asymetric problem (1 -> 2, 2 -> 1).
        /// </summary>
        private void CreateEdges(int[][] distanceMatrix)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                for (int j = 0; j < Points.Count; j++)
                {
                    if (i != j)
                    {
                        // Override this edge creation with matrix distance
                        Edge edge = new Edge(Points[i], Points[j]);
                        edge.Length = distanceMatrix[i][j];
                        Edges.Add(Helper.HashFunction(Points[i].Id, Points[j].Id), edge);
                    }
                }
            }
        }

        /// <summary>
        /// Return edge beetwen two points (their ID's) from Dictionary
        /// </summary>
        public Edge GetEdge(int firstPointId, int secondPointId)
        {
            // TODO @thangle override this
            return Edges[Helper.HashFunction(firstPointId, secondPointId)];
        }

        /// <summary>
        /// Set specific pheromone to all edges
        /// </summary>
        public void ResetPheromone(double pheromoneValue)
        {
            foreach (var edge in Edges)
            {
                edge.Value.Pheromone = pheromoneValue;
            }
        }

        public void EvaporatePheromone(Edge edge, double value)
        {
            edge.Pheromone = Math.Max(MinimumPheromone, edge.Pheromone * value); // Math.Max is here to prevent Pheromon = 0

            if (IsSymetric)
            {
                var secondEdge = GetEdge(edge.End.Id, edge.Start.Id);
                secondEdge.Pheromone = Math.Max(MinimumPheromone, secondEdge.Pheromone * value);
            }
        }

        public void DepositPheromone(Edge edge, double value)
        {
            edge.Pheromone += value;

            if (IsSymetric)
            {
                var secondEdge = GetEdge(edge.End.Id, edge.Start.Id);
                secondEdge.Pheromone += value;
            }
        }
    }
}