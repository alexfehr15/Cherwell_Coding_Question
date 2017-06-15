using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cherwell_Coding_Question
{
    public class VertexCoordinates : IEquatable<VertexCoordinates>
    {
        public int X { get { return _x; } }
        private readonly int _x;

        public int Y { get { return _y; } }
        private readonly int _y;

        public VertexCoordinates(int x, int y)
        {
            _x = x;
            _y = y;
        }

        #region IEquatable Implementation

        public override int GetHashCode()
        {
            return _x.GetHashCode() ^ _y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is VertexCoordinates))
                return false;

            return Equals((VertexCoordinates)obj);
        }

        public bool Equals(VertexCoordinates rhs)
        {
            if (_x != rhs._x) return false;
            if (_y != rhs._y) return false;

            return true;
        }

        public static bool operator ==(VertexCoordinates lhs, VertexCoordinates rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(VertexCoordinates lhs, VertexCoordinates rhs)
        {
            return !lhs.Equals(rhs);
        }

        #endregion
    }
}
