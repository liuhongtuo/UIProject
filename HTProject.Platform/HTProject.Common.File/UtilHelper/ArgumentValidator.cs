using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.File.UtilHelper
{
    /// <summary>
    /// Argument Validator
    /// </summary>
    public static class ArgumentValidator
    {
        private const string EmptyExceptionMessageFormat = "The {0} cannot be empty.";

        /// <summary>
        /// Validate refence type arguments.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argName"></param>
        /// <param name="arg"></param>
        /// <param name="exMsg"></param>
        public static void Validate<T>(string argName, T arg, string exMsg = null) where T : class
        {
            // validate object.
            if (arg == null)
            {
                throw new ArgumentNullException(argName, exMsg);
            }

            // validate string.
            string stingObj = arg as string;
            if (stingObj != null && string.IsNullOrWhiteSpace(stingObj))
            {
                throw new ArgumentException(string.Format(EmptyExceptionMessageFormat, argName), argName);
            }
        }

        /// <summary>
        /// Validate value type arguments.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argName"></param>
        /// <param name="arg"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="exMsg"></param>
        /// <param name="allowEqualMin"></param>
        /// <param name="allowEqualMax"></param>
        public static void Validate<T>(string argName, T arg, T? minValue = null, T? maxValue = null,
            bool allowEqualMin = true, bool allowEqualMax = true, string exMsg = null) where T : struct
        {
            dynamic argValue = arg;

            bool isValidMin = allowEqualMin ? argValue >= minValue : argValue > minValue;
            bool isValidMax = allowEqualMax ? argValue <= maxValue : argValue < maxValue;

            if (minValue != null && maxValue != null)
            {
                if (!isValidMin || !isValidMax)
                    throw new ArgumentOutOfRangeException(argName, exMsg);
            }

            if (minValue != null && maxValue == null)
            {
                if (!isValidMin)
                    throw new ArgumentOutOfRangeException(argName, exMsg);
            }

            if (minValue == null && maxValue != null)
            {
                if (!isValidMax)
                    throw new ArgumentOutOfRangeException(argName, exMsg);
            }
        }
    }
}
