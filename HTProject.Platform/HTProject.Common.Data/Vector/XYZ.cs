using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class XYZ : XY
    {
        public double Z { get; set; }

        #region Constructor

        public XYZ() { }

        public XYZ(double x, double y, double z) : base(x, y)
        {
            this.Z = z;
        }

        public XYZ(XY xy, double z = 0.0) : base((xy != null) ? xy.X : 0.0, (xy != null) ? xy.Y : 0.0)
        {
            this.Z = z;
        }

        public XYZ(XZ xz, double y = 0.0)
        {
            base.X = ((xz != null) ? xz.X : 0.0);
            this.Z = ((xz != null) ? xz.Z : 0.0);
            base.Y = y;
        }

        public XYZ(YZ yz, double x = 0.0)
        {
            base.Y = ((yz != null) ? yz.Y : 0.0);
            this.Z = ((yz != null) ? yz.Z : 0.0);
            base.X = x;
        }

        #endregion

        #region Override

        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as XYZ);
        }

        public bool Equals(XYZ xyz)
        {
            return xyz == null ? false : (base.Equals(xyz) && this.Z == xyz.Z);
        }

        public override string ToString() => $"[X] = [{base.X}], [Y] = [{base.Y}], [Z] = [{this.Z}].";

        public override int GetHashCode() => base.GetHashCode() ^ this.Z.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(XYZ a, XYZ b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(XYZ a, XYZ b)
        {
            return !(a == b);
        }

        public static XYZ operator +(XYZ a, XYZ b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XYZ(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static XYZ operator -(XYZ a, XYZ b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XYZ(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        #endregion

        public XY ToXY()
        {
            return this;
        }

        public XZ ToXZ()
        {
            return new XZ(base.X, this.Z);
        }

        public YZ ToYZ()
        {
            return new YZ(base.Y, this.Z);
        }
    }
}
