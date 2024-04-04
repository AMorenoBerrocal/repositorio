using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    public class CalculationOperationNotSupportedException : Exception
    {
        public string Operation { get; }

        private const string DefaultMessage = "Error durante el cálculo: inténtelo de nuevo";
        public CalculationOperationNotSupportedException() : base(DefaultMessage) { }

        public CalculationOperationNotSupportedException(string message) : base(message) { }

        public CalculationOperationNotSupportedException(Exception innerException) : base(DefaultMessage, innerException) { }

        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException) { }

        public CalculationOperationNotSupportedException(string operation, string message) : base(message) => Operation = operation;
    }

    
}
