using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation = 
                operation ?? throw new ArgumentNullException(nameof(operation));

            
            if (nonNullOperation == "/"){
                try
                {
                    return Divide(number1, number2);
                } catch (DivideByZeroException ex)
                {
                    Console.WriteLine("...division por 0...");
                    throw new ArithmeticException("Error durante el calculo", ex);
                }
            } else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "Esa operacion matemática no tiene soporte");
            }
        }

        private int Divide(int number, int divisor) => number / divisor;

    }
}
