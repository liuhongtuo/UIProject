using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class YZ
    {
        public double Y { get; set; }

        public double Z { get; set; }

        #region Constructor

        public YZ() { }

        public YZ(double y, double z)
        {
            this.Y = y;
            this.Z = z;
        }

        #endregion

        #region Override

        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as YZ);
        }

        public bool Equals(YZ yz)
        {
            return yz == null ? false : (this.Y == yz.Y && this.Z == yz.Z);
        }

        public override string ToString() => $"[Y] = [{this.Y}], [Z] = [{this.Z}].";
        
        public override int GetHashCode() => this.Y.GetHashCode() ^ this.Z.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(YZ a, YZ b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(YZ a, YZ b)
        {
            return !(a == b);
        }

        public static YZ operator +(YZ a, YZ b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new YZ(a.Y + b.Y, a.Z + b.Z);
        }

        public static YZ operator -(YZ a, YZ b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

           return new YZ(a.Y - b.Y, a.Z - b.Z);
        }

        #endregion
    }
}
