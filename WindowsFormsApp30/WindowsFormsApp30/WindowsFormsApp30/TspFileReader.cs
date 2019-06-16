using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AntColonySystem
{
    public static class TspFileReader
    {
        private static string END_OF_FILE = "EOF";

        // TODO @thangle: Don't use this
        public static List<Point> ReadTspFile(string tspFilePath)
        {
            var file = File.ReadLines(tspFilePath);
            List<Point> points = new List<Point>();

            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            bool readData = true;
            foreach (var item in file)
            {
                if (item.Contains(END_OF_FILE))
                {
                    readData = false;
                }
                if (readData)
                {
                    string[] spitted = item.Split(' ').Where(x => x != string.Empty).ToArray();

                    // TODO @thangle: Check this point creation logic
                    int pointId = int.Parse(spitted[1]);
                    float pointX = float.Parse(spitted[1], NumberStyles.Any, ci);
                    float pointY = float.Parse(spitted[2], NumberStyles.Any, ci);
                    // TODO @thangle: The point ID and coordinate is incorrect !
                    Point newPoint = new Point(pointId, pointX, pointY);
                    points.Add(newPoint);
                }
            }

            return points;
        }
    }
}