using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class ZRxRy : RxRy
    {
        public double Z { get; set; }

        #region Constructor

        public ZRxRy() { }

        public ZRxRy(double z, double rx, double ry) : base(rx, ry)
        {
            this.Z = z;
        }

        public ZRxRy(RxRy rxry, double z = 0.0)
        {
            base.Rx = ((rxry != null) ? rxry.Rx : 0.0);
            base.Ry = ((rxry != null) ? rxry.Ry : 0.0);
            this.Z = z;
        }

        #endregion

        #region Override

        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as ZRxRy);
        }

        public bool Equals(ZRxRy zRxRy)
        {
            return zRxRy == null ? false : (base.Equals(zRxRy) && this.Z == zRxRy.Z);
        }

        public override string ToString() => $"[Z] = [{this.Z}], [Rx] = [{base.Rx}], [Ry] = [{base.Ry}].";

        public override int GetHashCode() => base.GetHashCode() ^ this.Z.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(ZRxRy a, ZRxRy b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.Z == b.Z && a.Rx == b.Rx && a.Ry == b.Ry;
        }

        public static bool operator !=(ZRxRy a, ZRxRy b)
        {
            return !(a == b);
        }

        public static ZRxRy operator +(ZRxRy a, ZRxRy b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new ZRxRy(a.Z + b.Z, a.Rx + b.Rx, a.Ry + b.Ry);
        }

        public static ZRxRy operator -(ZRxRy a, ZRxRy b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new ZRxRy(a.Z - b.Z, a.Rx - b.Rx, a.Ry - b.Ry);
        }

        #endregion

        public RxRy ToRxRy()
        {
            return this;
        }
    }
}
