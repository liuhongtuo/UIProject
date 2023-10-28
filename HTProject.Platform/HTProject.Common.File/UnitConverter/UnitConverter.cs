using HTProject.Common.Data.Vector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HTProject.Common.File.UnitConverter
{
    public class UnitConverter
    {
        public static double ConvertUnitMM2M(double value) => value / 1e3;

        public static XY ConvertUnitMM2M(XY pos) => new XY { X = pos.X / 1e3, Y = pos.Y / 1e3 };

        public static XY ConvertUnitMM2M(Point pt) => new XY { X = pt.X / 1e3, Y = pt.Y / 1e3 };

        public static double ConvertUnitM2MM(double value) => value * 1e3;

        public static XY ConvertUnitM2MM(XY pos) => new XY { X = pos.X * 1e3, Y = pos.Y * 1e3 };

        // um -> m
        public static double UM2M(double value) => value / 1e6;
        public static XY UM2M(XY pos) => new XY { X = pos.X / 1e6, Y = pos.Y / 1e6 };

        // m -> um (1m = 1000000um)
        public static double M2UM(double value) => value * 1e6;
        public static double SquareM2UM(double value) => value * 1e12;
        public static XY M2UM(XY pos) => new XY { X = pos.X * 1e6, Y = pos.Y * 1e6 };

        // um -> mm
        public static double UM2MM(double value) => value / 1e3;
        public static XY UM2MM(Point pt) => new XY { X = pt.X / 1e3, Y = pt.Y / 1e3 };

        // mm -> um (1mm = 1000um)
        public static double MM2UM(double value) => value * 1e3;
        public static XY MM2UM(XY pos) => new XY { X = pos.X * 1e3, Y = pos.Y * 1e3 };

        public static double Angule2Rad(double angule) => Math.PI / 180 * angule;

        public static double Angule2MRad(double angule) => Angule2Rad(angule) * 1e3;

        public static double Angule2URad(double angule) => Angule2MRad(angule) * 1e3;

        //mrad=>rad(1rad==1000mrad)
        public static double MRad2Rad(double rad) => rad / 1e3;

        //mrad=>rad(1rad==1000mrad)
        public static double Rad2MRad(double rad) => rad * 1e3;
    }
}
