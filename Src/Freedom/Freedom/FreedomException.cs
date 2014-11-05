using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom
{
    [Serializable]
    public class FreedomException : Exception
    {
        public FreedomException() { }
        public FreedomException(string message) : base(message) { }
        public FreedomException(string message, Exception inner) : base(message, inner) { }
        protected FreedomException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

}
