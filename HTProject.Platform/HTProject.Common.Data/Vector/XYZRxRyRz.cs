using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.Vector
{
    [Serializable]
    public class XYZRxRyRz : XYZ
    {
        public double Rx { get; set; }

        public double Ry { get; set; }

        public double Rz { get; set; }

        #region Constructor

        public XYZRxRyRz() { }

        public XYZRxRyRz(double x, double y, double z, double rx, double ry, double rz) : base(x, y, z)
        {
            this.Rx = rx;
            this.Ry = ry;
            this.Rz = rz;
        }

        public XYZRxRyRz(double x, double y)
        {
            base.X = x;
            base.Y = y;
        }

        public XYZRxRyRz(double x, double y, double z) : this(x, y)
        {
            base.Z = z;
        }

        public XYZRxRyRz(XYZ xyz, double rx = 0.0, double ry = 0.0, double rz = 0.0) : base((xyz != null) ? xyz.X : 0.0, (xyz != null) ? xyz.Y : 0.0, (xyz != null) ? xyz.Z : 0.0)
        {
            this.Rx = rx;
            this.Ry = ry;
            this.Rz = rz;
        }

        public XYZRxRyRz(XYRz xyrz, double z = 0.0, double rx = 0.0, double ry = 0.0) : base((xyrz != null) ? xyrz.X : 0.0, (xyrz != null) ? xyrz.Y : 0.0, z)
        {
            this.Rx = rx;
            this.Ry = ry;
            this.Rz = ((xyrz != null) ? xyrz.Rz : 0.0);
        }

        public XYZRxRyRz(ZRxRy zrxry, double x = 0.0, double y = 0.0, double rz = 0.0)
        {
            base.X = x;
            base.Y = y;
            base.Z = ((zrxry != null) ? zrxry.Z : 0.0);
            this.Rx = ((zrxry != null) ? zrxry.Rx : 0.0);
            this.Ry = ((zrxry != null) ? zrxry.Ry : 0.0);
            this.Rz = rz;
        }

        public XYZRxRyRz(XYRz xyrz, ZRxRy zrxry)
        {
            base.X = ((xyrz != null) ? xyrz.X : 0.0);
            base.Y = ((xyrz != null) ? xyrz.Y : 0.0);
            this.Rz = ((xyrz != null) ? xyrz.Rz : 0.0);
            base.Z = ((zrxry != null) ? zrxry.Z : 0.0);
            this.Rx = ((zrxry != null) ? zrxry.Rx : 0.0);
            this.Ry = ((zrxry != null) ? zrxry.Ry : 0.0);
        }

        #endregion

        #region Override

        public override bool Equals(object obj)
        {
            return obj == null ? false : Equals(obj as XYZRxRyRz);
        }

        public bool Equals(XYZRxRyRz dto)
        {
            return dto == null ? false : (base.Equals(dto) && this.Rx == dto.Rx && this.Ry == dto.Ry && this.Rz == dto.Rz);
        }

        public override string ToString()
            => $"[X] = [{ base.X}], [Y] = [{base.Y}], [Z] = [{base.Z}], [Rx] = [{this.Rx}], [Ry] = [{this.Ry}], [Rz] = [{this.Rz}].";

        public override int GetHashCode()
            => base.GetHashCode() ^ this.Rx.GetHashCode() ^ this.Ry.GetHashCode() ^ this.Rz.GetHashCode();

        #endregion

        #region Operator Override

        public static bool operator ==(XYZRxRyRz a, XYZRxRyRz b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.Rx == b.Rx && a.Ry == b.Ry && a.Rz == b.Rz;
        }

        public static bool operator !=(XYZRxRyRz a, XYZRxRyRz b)
        {
            return !(a == b);
        }

        public static XYZRxRyRz operator +(XYZRxRyRz a, XYZRxRyRz b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XYZRxRyRz(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.Rx + b.Rx, a.Ry + b.Ry, a.Rz + b.Rz);
        }

        public static XYZRxRyRz operator -(XYZRxRyRz a, XYZRxRyRz b)
        {
            if (a == null || b == null)
            {
                return a != null ? a : (b != null ? b : null);
            }

            return new XYZRxRyRz(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.Rx - b.Rx, a.Ry - b.Ry, a.Rz - b.Rz);
        }

        #endregion

        public XYZ ToXYZ()
        {
            return this;
        }

        public XYRz ToXYRz()
        {
            return new XYRz(base.X, base.Y, this.Rz);
        }

        public ZRxRy ToZRxRy()
        {
            return new ZRxRy(base.Z, this.Rx, this.Ry);
        }
    }
}
