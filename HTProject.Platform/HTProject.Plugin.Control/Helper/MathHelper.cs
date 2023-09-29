using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Plugin.Control.Helper
{
    public static class MathHelper
    {
        public static double Between(this double value, double maximum, double minimum, double? defaultvalue = null)
        {
            if (maximum < minimum)
            {
                return (maximum + minimum) / 2;
            }
            else
            {
                var res = Math.Max(Math.Min(value, maximum), minimum);
                if (res != value && defaultvalue != null)//越界且有默认值
                {
                    var r = (double)defaultvalue;
                    return r;
                }
                else
                {
                    return res;
                }
            }
        }

        public static int Between(this int value, int maximum, int minimum, int? defaultvalue = null)
        {
            if (maximum < minimum)
            {
                return (maximum + minimum) / 2;
            }
            else
            {
                var res = Math.Max(Math.Min(value, maximum), minimum);
                if (res != value && defaultvalue != null)//越界且有默认值
                {
                    return (int)defaultvalue;
                }
                else
                {
                    return res;
                }
            }
        }
    }
}
