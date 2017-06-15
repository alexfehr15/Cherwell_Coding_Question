using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cherwell_Coding_Question
{
    public struct RowColumn : IEquatable<RowColumn>
    {
        public char Row { get { return _row; } }
        private readonly char _row;

        public int Column { get { return _column; } }
        private readonly int _column; 

        public RowColumn(char row, int column)
        {
            _row = row;
            _column = column;
        }

        #region IEquatable Implementation

        public override int GetHashCode()
        {
            return _row.GetHashCode() ^ _column.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RowColumn))
                return false;

            return Equals((RowColumn)obj);
        }

        public bool Equals(RowColumn rhs)
        {
            if (_row != rhs._row) return false;
            if (_column != rhs._column) return false;

            return true;
        }

        public static bool operator ==(RowColumn lhs, RowColumn rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(RowColumn lhs, RowColumn rhs)
        {
            return !lhs.Equals(rhs);
        }

        #endregion
    }
}
