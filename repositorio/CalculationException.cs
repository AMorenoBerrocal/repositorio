using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    public class CalculationException : Exception
    {
        private const string DefaultMessage = "Error durante el cálculo: inténtelo de nuevo";
        public CalculationException() : base(DefaultMessage) { }

        public CalculationException(string message) : base(message) { }

        public CalculationException(Exception innerException) : base(DefaultMessage, innerException) { }

        public CalculationException(string message, Exception innerException) : base(message, innerException) { } 
        


    }
}
