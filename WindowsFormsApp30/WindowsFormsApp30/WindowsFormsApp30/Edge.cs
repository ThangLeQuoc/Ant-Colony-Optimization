using System;

namespace AntColonySystem
{
    public class Edge
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public double Length { get; set; }
        public double Pheromone { get; set; }
        public double Weight { get; set; }

        public Edge() { }

        public Edge(Point start, Point end)
        {
            Start = start;
            End = end;
            // TODO @thangle: Find a way to skip this, since the dimension already provide the the distance
            Length = Math.Round(Start.DistanceTo(End));
        }
    }
}