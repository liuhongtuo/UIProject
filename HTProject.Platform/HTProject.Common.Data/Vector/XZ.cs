using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class XZ
    {
        public double X { get; set; }

        public double Z { get; set; }

        #region Constructor

        public XZ() { }

        public XZ(double x, double z)
        {
            this.X = x;
            this.Z = z;
        }

        #endregion
        
        #region Override
        
        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as XZ);
        }

        public bool Equals(XZ xz)
        {
            return xz == null ? false : (this.X == xz.X && this.Z == xz.Z);
        }

        public override string ToString() => $"[X] = [{this.X}], [Z] = [{this.Z}].";

        public override int GetHashCode() => this.X.GetHashCode() ^ this.Z.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(XZ a, XZ b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return  a.X == b.X && a.Z == b.Z;
        }

        public static bool operator !=(XZ a, XZ b)
        {
            return !(a == b);
        }

        public static XZ operator +(XZ a, XZ b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XZ(a.X + b.X, a.Z + b.Z);
        }

        public static XZ operator -(XZ a, XZ b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XZ(a.X - b.X, a.Z - b.Z);
        }

        #endregion
    }
}
