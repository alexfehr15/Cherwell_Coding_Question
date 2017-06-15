using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cherwell_Coding_Question
{
    public struct Triangle : IEquatable<Triangle>
    {
        #region Vertex Axis to Pixel Mapping

        public static readonly Dictionary<int, int> s_xCoordinateToPixelDictionary = new Dictionary<int, int>
        {
            { 0, 0 }, { 1, 10 }, { 2, 10 }, { 3, 20 }, { 4, 20 }, { 5, 30 }, { 6, 30 }, { 7, 40 }, { 8, 40 }, { 9, 50 }, { 10, 50 }, { 11, 60 }, { 12, 60 }
        };

        public static readonly Dictionary<int, int> s_yCoordinateToPixelDictionary = new Dictionary<int, int>
        {
            { 0, 0 }, { 1, 10 }, { 2, 20 }, { 3, 10 }, { 4, 20 }, { 5, 30 }, { 6, 40 }, { 7, 30 }, { 8, 40 }, { 9, 50 }, { 10, 60 }, { 11, 50 }, { 12, 60 }
        };

        #endregion

        public IEnumerable<PixelCoordinates> PixelCoordinates { get { return _pixelCoordinates; } }
        private readonly HashSet<PixelCoordinates> _pixelCoordinates;

        public Triangle(IEnumerable<PixelCoordinates> pixelCoordinates)
        {
            _pixelCoordinates = new HashSet<PixelCoordinates>(pixelCoordinates);
        }

        public Triangle(IEnumerable<VertexCoordinates> vertexCoordinates)
        {
            IEnumerable<PixelCoordinates> pixelCoordinates = VertexCoordinatesToPixelCoordinates(vertexCoordinates);
            _pixelCoordinates = pixelCoordinates != null ? new HashSet<PixelCoordinates>(pixelCoordinates) : null;
        }

        private static IEnumerable<PixelCoordinates> VertexCoordinatesToPixelCoordinates(IEnumerable<VertexCoordinates> vertexCoordinates)
        {
            List<PixelCoordinates> pixelCoordinates = new List<PixelCoordinates>();
            foreach (VertexCoordinates coordinates in vertexCoordinates)
            {
                int x, y;
                if (s_xCoordinateToPixelDictionary.TryGetValue(coordinates.X, out x) && s_yCoordinateToPixelDictionary.TryGetValue(coordinates.Y, out y))
                {
                    pixelCoordinates.Add(new PixelCoordinates(x, y));
                }
            }

            return pixelCoordinates.Count == 3 ? pixelCoordinates : null;
        }

        #region IEquatable Implementation

        public override int GetHashCode()
        {
            int hash = 17;
            foreach (PixelCoordinates p in _pixelCoordinates)
                hash = hash + p.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Triangle))
                return false;

            return Equals((Triangle)obj);
        }

        public bool Equals(Triangle rhs)
        {
            foreach (PixelCoordinates p in rhs._pixelCoordinates)
            {
                if (!_pixelCoordinates.Contains(p)) return false;
            }

            return true;
        }

        public static bool operator ==(Triangle lhs, Triangle rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Triangle lhs, Triangle rhs)
        {
            return !lhs.Equals(rhs);
        }

        #endregion
    }
}
