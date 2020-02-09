using System.Collections.Generic;

namespace LangtonsAnt
{
    public class Grid
    {
        public Grid(int numberOfRows, int numberOfColumns)
        {
            var columns = new List<Point>();
            var rows = new List<Point>();

            for (int i = 0; i <= numberOfRows; i++)
            {
                rows.Add(new Point());
            }
            for (int i = 0; i <= numberOfColumns; i++)
            {
                columns.Add(new Point());
            }

            Points = new Point[][] { rows.ToArray(), columns.ToArray() };
        }

        public Point[][] Points { get; set; }
    }
}
