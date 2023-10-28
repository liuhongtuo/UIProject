using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class RxRy
    {
        public double Rx { get; set; }

        public double Ry { get; set; }

        #region Constructor

        public RxRy() { }

        public RxRy(double rx, double ry)
        {
            this.Rx = rx;
            this.Ry = ry;
        }

        #endregion

        #region Override
        
        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as RxRy);
        }

        public bool Equals(RxRy rxRy)
        {
            return rxRy == null ? false : (this.Rx == rxRy.Rx && this.Ry == rxRy.Ry);
        }

        public override string ToString() => $"[Rx] = [{this.Rx}], [Ry] = [{this.Ry}].";

        public override int GetHashCode() => this.Rx.GetHashCode() ^ this.Ry.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(RxRy a, RxRy b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.Rx == b.Rx && a.Ry == b.Ry;
        }

        public static bool operator !=(RxRy a, RxRy b)
        {
            return !(a == b);
        }

        public static RxRy operator +(RxRy a, RxRy b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new RxRy(a.Rx + b.Rx, a.Ry + b.Ry);
        }

        public static RxRy operator -(RxRy a, RxRy b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new RxRy(a.Rx - b.Rx, a.Ry - b.Ry);
        }

        #endregion
    }
}
