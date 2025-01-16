using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopamineDetox.ServiceAgent.Exceptions
{
    public class ServiceAgentException : Exception
    {
        public ServiceAgentException(string message) : base(message) { }
        public ServiceAgentException(string message, Exception innerException) : base(message, innerException) { }
    }
}
