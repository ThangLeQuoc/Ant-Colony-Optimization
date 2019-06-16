using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AntColonySystem
{
    public static class AcoFileReader
    {
        private static string END_OF_FILE = "EOF";

        private static int[][] matrix;

        public static List<Point> ReadACOFile(string acoFilePath)
        {
            var file = File.ReadLines(acoFilePath);
            List<Point> points = new List<Point>();
            
            int lineCount = file.Count();
            for (int lineIndex = 0; lineIndex < lineCount; lineIndex++) {
                    Point newPoint = new Point(lineIndex, -1, -1);
                    points.Add(newPoint);
            }

            // init data for distance matrix
            matrix = new int[lineCount][];
            int i = 0;

            foreach (var item in file)
            {
                string[] row = item.Split(' ').Where(x => x != string.Empty).ToArray();
                matrix[i] = new int[lineCount];
                for (int j = 0; j < row.Length; j++) {
                    matrix[i][j] = int.Parse(row[j]);
                }
                i++;
                
            }

            return points;
        }

        public static int[][] GetDistanceMatrix()
        {
            return matrix;   
        }
    }
}