using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Contract.MEMS.Exceptions
{
    [Serializable]
    public class MEException : Exception
    {
        private const string msgFormat = "[ME_Component] {0} Please check the MEMS log for details.";

        public MEException(string message) : base(string.Format(msgFormat, message)) { }

        public MEException(string message, Exception innerException) : base(string.Format(msgFormat, message), innerException) { }

        public MEException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
