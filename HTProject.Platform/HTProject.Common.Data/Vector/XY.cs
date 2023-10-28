using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class XY
    {
        public double X { get; set; } = 0.00;

        public double Y { get; set; } = 0.00;

        #region Constructor

        public XY() { }

        public XY(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Override
       
        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as XY);
        }

        public bool Equals(XY dto)
        {
            return dto == null ? false : (this.X == dto.X && this.Y == dto.Y);
        }

        public override string ToString() => $"[X] = [{this.X}], [Y] = [{this.Y}].";

        public override int GetHashCode() => this.X.GetHashCode() ^ this.Y.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(XY a, XY b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(XY a, XY b)
        {
            return !(a == b);
        }

        public static XY operator +(XY a, XY b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XY(a.X + b.X, a.Y + b.Y);
        }

        public static XY operator -(XY a, XY b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XY(a.X - b.X, a.Y - b.Y);
        }

        public static XY operator *(XY a, double b)
        {
            if (a == null)
                return a;

            return new XY(a.X * b, a.Y * b);
        }

        public static XY operator /(XY a, double b)
        {
            if (a == null || b == 0)
                return a;

            return new XY(a.X / b, a.Y / b);
        }

        public static bool operator >(XY a, XY b)
        {
            if (a == null || b == null)
                return false;

            return a.X > b.X && a.Y > b.Y;
        }

        public static bool operator <(XY a, XY b)
        {
            if (a == null || b == null)
                return false;

            return a.X < b.X && a.Y < b.Y;
        }

        public static bool operator >=(XY a, XY b)
        {
            if (a == null || b == null)
                return a == null && b == null;

            return a.X >= b.X && a.Y >= b.Y;
        }

        public static bool operator <=(XY a, XY b)
        {
            if (a == null || b == null)
                return a == null && b == null;

            return a.X <= b.X && a.Y <= b.Y;
        }

        #endregion
    }
}
