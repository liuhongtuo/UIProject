using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class XYRz : XY
    {
        public double Rz { get; set; }

        #region Constructor

        public XYRz() { }

        public XYRz(double x, double y, double rz) : base(x, y)
        {
            this.Rz = rz;
        }

        public XYRz(XY xy, double rz = 0.0) : base((xy != null) ? xy.X : 0.0, (xy != null) ? xy.Y : 0.0)
        {
            this.Rz = rz;
        }

        #endregion

        #region Override
        
        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as XYRz);
        }

        public bool Equals(XYRz xyRz)
        {
            return xyRz == null ? false : (base.Equals(xyRz) && this.Rz == xyRz.Rz);
        }

        public override string ToString() => $"[X] = [{base.X}], [Y] = [{base.Y}], [Rz] = [{this.Rz}].";

        public override int GetHashCode() => base.GetHashCode() ^ this.Rz.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(XYRz a, XYRz b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.X == b.X && a.Y == b.Y && a.Rz == b.Rz;
        }

        public static bool operator !=(XYRz a, XYRz b)
        {
            return !(a == b);
        }

        public static XYRz operator +(XYRz a, XYRz b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XYRz(a.X + b.X, a.Y + b.Y, a.Rz + b.Rz);
        }

        public static XYRz operator -(XYRz a, XYRz b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XYRz(a.X - b.X, a.Y - b.Y, a.Rz - b.Rz);
        }

        #endregion

        public XY ToXY()
        {
            return this;
        }
    }
}