using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cherwell_Coding_Question
{
    public class Program
    {
        #region Pixel Coordinates to Row Column Dictionary

        private static Dictionary<Triangle, RowColumn> s_pixelCoordinatesToRowColumnDictionary = new Dictionary<Triangle, RowColumn>
        {
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(0, 0), new PixelCoordinates(10,0), new PixelCoordinates(0,10) }), new RowColumn('F', 1) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 10), new PixelCoordinates(10,0), new PixelCoordinates(0,10) }), new RowColumn('F', 2) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 0), new PixelCoordinates(20,0), new PixelCoordinates(10,10) }), new RowColumn('F', 3) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 10), new PixelCoordinates(20,0), new PixelCoordinates(10,10) }), new RowColumn('F', 4) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 0), new PixelCoordinates(30,0), new PixelCoordinates(20,10) }), new RowColumn('F', 5) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 10), new PixelCoordinates(30,0), new PixelCoordinates(20,10) }), new RowColumn('F', 6) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 0), new PixelCoordinates(40,0), new PixelCoordinates(30,10) }), new RowColumn('F', 7) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 10), new PixelCoordinates(40,0), new PixelCoordinates(30,10) }), new RowColumn('F', 8) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 0), new PixelCoordinates(50,0), new PixelCoordinates(40,10) }), new RowColumn('F', 9) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 10), new PixelCoordinates(50,0), new PixelCoordinates(40,10) }), new RowColumn('F', 10) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 0), new PixelCoordinates(60,0), new PixelCoordinates(50,10) }), new RowColumn('F', 11) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(60, 10), new PixelCoordinates(60,0), new PixelCoordinates(50,10) }), new RowColumn('F', 12) },

                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(0, 10), new PixelCoordinates(10,10), new PixelCoordinates(0,20) }), new RowColumn('E', 1) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 20), new PixelCoordinates(10,10), new PixelCoordinates(0,20) }), new RowColumn('E', 2) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 10), new PixelCoordinates(20,10), new PixelCoordinates(10,20) }), new RowColumn('E', 3) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 20), new PixelCoordinates(20,10), new PixelCoordinates(10,20) }), new RowColumn('E', 4) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 10), new PixelCoordinates(30,10), new PixelCoordinates(20,20) }), new RowColumn('E', 5) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 20), new PixelCoordinates(30,10), new PixelCoordinates(20,20) }), new RowColumn('E', 6) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 10), new PixelCoordinates(40,10), new PixelCoordinates(30,20) }), new RowColumn('E', 7) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 20), new PixelCoordinates(40,10), new PixelCoordinates(30,20) }), new RowColumn('E', 8) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 10), new PixelCoordinates(50,10), new PixelCoordinates(40,20) }), new RowColumn('E', 9) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 20), new PixelCoordinates(50,10), new PixelCoordinates(40,20) }), new RowColumn('E', 10) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 10), new PixelCoordinates(60,10), new PixelCoordinates(50,20) }), new RowColumn('E', 11) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(60, 20), new PixelCoordinates(60,10), new PixelCoordinates(50,20) }), new RowColumn('E', 12) },

                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(0, 20), new PixelCoordinates(10,20), new PixelCoordinates(0,30) }), new RowColumn('D', 1) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 30), new PixelCoordinates(10,20), new PixelCoordinates(0,30) }), new RowColumn('D', 2) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 20), new PixelCoordinates(20,20), new PixelCoordinates(10,30) }), new RowColumn('D', 3) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 30), new PixelCoordinates(20,20), new PixelCoordinates(10,30) }), new RowColumn('D', 4) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 20), new PixelCoordinates(30,20), new PixelCoordinates(20,30) }), new RowColumn('D', 5) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 30), new PixelCoordinates(30,20), new PixelCoordinates(20,30) }), new RowColumn('D', 6) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 20), new PixelCoordinates(40,20), new PixelCoordinates(30,30) }), new RowColumn('D', 7) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 30), new PixelCoordinates(40,20), new PixelCoordinates(30,30) }), new RowColumn('D', 8) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 20), new PixelCoordinates(50,20), new PixelCoordinates(40,30) }), new RowColumn('D', 9) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 30), new PixelCoordinates(50,20), new PixelCoordinates(40,30) }), new RowColumn('D', 10) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 20), new PixelCoordinates(60,20), new PixelCoordinates(50,30) }), new RowColumn('D', 11) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(60, 30), new PixelCoordinates(60,20), new PixelCoordinates(50,30) }), new RowColumn('D', 12) },

                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(0, 30), new PixelCoordinates(10,30), new PixelCoordinates(0,40) }), new RowColumn('C', 1) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 40), new PixelCoordinates(10,30), new PixelCoordinates(0,40) }), new RowColumn('C', 2) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 30), new PixelCoordinates(20,30), new PixelCoordinates(10,40) }), new RowColumn('C', 3) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 40), new PixelCoordinates(20,30), new PixelCoordinates(10,40) }), new RowColumn('C', 4) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 30), new PixelCoordinates(30,30), new PixelCoordinates(20,40) }), new RowColumn('C', 5) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 40), new PixelCoordinates(30,30), new PixelCoordinates(20,40) }), new RowColumn('C', 6) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 30), new PixelCoordinates(40,30), new PixelCoordinates(30,40) }), new RowColumn('C', 7) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 40), new PixelCoordinates(40,30), new PixelCoordinates(30,40) }), new RowColumn('C', 8) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 30), new PixelCoordinates(50,30), new PixelCoordinates(40,40) }), new RowColumn('C', 9) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 40), new PixelCoordinates(50,30), new PixelCoordinates(40,40) }), new RowColumn('C', 10) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 30), new PixelCoordinates(60,30), new PixelCoordinates(50,40) }), new RowColumn('C', 11) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(60, 40), new PixelCoordinates(60,30), new PixelCoordinates(50,40) }), new RowColumn('C', 12) },

                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(0, 40), new PixelCoordinates(10,40), new PixelCoordinates(0,50) }), new RowColumn('B', 1) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 50), new PixelCoordinates(10,40), new PixelCoordinates(0,50) }), new RowColumn('B', 2) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 40), new PixelCoordinates(20,40), new PixelCoordinates(10,50) }), new RowColumn('B', 3) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 50), new PixelCoordinates(20,40), new PixelCoordinates(10,50) }), new RowColumn('B', 4) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 40), new PixelCoordinates(30,40), new PixelCoordinates(20,50) }), new RowColumn('B', 5) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 50), new PixelCoordinates(30,40), new PixelCoordinates(20,50) }), new RowColumn('B', 6) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 40), new PixelCoordinates(40,40), new PixelCoordinates(30,50) }), new RowColumn('B', 7) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 50), new PixelCoordinates(40,40), new PixelCoordinates(30,50) }), new RowColumn('B', 8) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 40), new PixelCoordinates(50,40), new PixelCoordinates(40,50) }), new RowColumn('B', 9) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 50), new PixelCoordinates(50,40), new PixelCoordinates(40,50) }), new RowColumn('B', 10) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 40), new PixelCoordinates(60,40), new PixelCoordinates(50,50) }), new RowColumn('B', 11) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(60, 50), new PixelCoordinates(60,40), new PixelCoordinates(50,50) }), new RowColumn('B', 12) },

                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(0, 50), new PixelCoordinates(10,0), new PixelCoordinates(0,60) }), new RowColumn('A', 1) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 60), new PixelCoordinates(10,50), new PixelCoordinates(0,60) }), new RowColumn('A', 2) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(10, 50), new PixelCoordinates(20,50), new PixelCoordinates(10,60) }), new RowColumn('A', 3) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 60), new PixelCoordinates(20,50), new PixelCoordinates(10,60) }), new RowColumn('A', 4) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(20, 50), new PixelCoordinates(30,50), new PixelCoordinates(20,60) }), new RowColumn('A', 5) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 60), new PixelCoordinates(30,50), new PixelCoordinates(20,60) }), new RowColumn('A', 6) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(30, 50), new PixelCoordinates(40,50), new PixelCoordinates(30,60) }), new RowColumn('A', 7) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 60), new PixelCoordinates(40,50), new PixelCoordinates(30,60) }), new RowColumn('A', 8) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(40, 50), new PixelCoordinates(50,50), new PixelCoordinates(40,60) }), new RowColumn('A', 9) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 60), new PixelCoordinates(50,50), new PixelCoordinates(40,60) }), new RowColumn('A', 10) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(50, 50), new PixelCoordinates(60,50), new PixelCoordinates(50,60) }), new RowColumn('A', 11) },
                { new Triangle( new List<PixelCoordinates> { new PixelCoordinates(60, 60), new PixelCoordinates(60,50), new PixelCoordinates(50,60) }), new RowColumn('A', 12) },
        };

        #endregion

        public static void Main(string[] args)
        {
            RowColumn rowColumn = GetRowColumn(new List<VertexCoordinates> { new VertexCoordinates(1, 1), new VertexCoordinates(2, 2), new VertexCoordinates(3, 3) });
            Console.WriteLine(string.Format("{0}{1}", rowColumn.Row, rowColumn.Column));

            Console.ReadLine();
        }

        public static RowColumn GetRowColumn(IEnumerable<PixelCoordinates> pixelCoordinates)
        {
            Triangle triangle = new Triangle(pixelCoordinates);

            RowColumn rowColumn;
            if (s_pixelCoordinatesToRowColumnDictionary.TryGetValue(triangle, out rowColumn))
            {
                return rowColumn;
            }
            else
            {
                return new RowColumn();
            }
        }

        public static RowColumn GetRowColumn(IEnumerable<VertexCoordinates> vertexCoordinates)
        {
            Triangle triangle = new Triangle(vertexCoordinates);

            RowColumn rowColumn;
            if (s_pixelCoordinatesToRowColumnDictionary.TryGetValue(triangle, out rowColumn))
            {
                return rowColumn;
            }
            else
            {
                return new RowColumn();
            }
        }
    }
}
