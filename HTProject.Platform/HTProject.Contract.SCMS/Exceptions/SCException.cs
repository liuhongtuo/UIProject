using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Contract.SCMS.Exceptions
{
    [Serializable]
    public class SCException : Exception
    {
        private const string msgFormat = "[SC_Component] {0} Please check the SCMS log for details.";

        public SCException(string message) : base(string.Format(msgFormat, message)) { }

        public SCException(string message, Exception innerException) : base(string.Format(msgFormat, message), innerException) { }

        public SCException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
