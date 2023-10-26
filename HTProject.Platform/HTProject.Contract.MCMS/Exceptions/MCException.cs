using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Contract.MCMS.Exceptions
{
    [Serializable]
    public class MCException : Exception
    {
        private const string msgFormat = "[MC] {0} Please check whether the MakingCode and xPath.";

        public MCException(string message) : base(string.Format(msgFormat, message)) { }

        public MCException(string message, Exception innerException) : base(string.Format(msgFormat, message), innerException) { }

        public MCException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
