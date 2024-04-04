using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    public class Division {
        public static void main(string[] args)
        {
            Console.WriteLine("Primer operando: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo operando: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca operacion: ");
            string operacion = Console.ReadLine();

            try
            {
                var calculator = new Calculator();
                int result = calculator.Calculate(number1, number2, operacion);
                DisplayResult(result);
            } catch (ArgumentNullException e) when (e.ParamName == "operation")
            {
                Console.WriteLine("Operacion no proporcionada");
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Operación sin soporte");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hubo un problema: {e.Message}");
            }
            static void DisplayResult(int result) => Console.WriteLine($"Result is: {result}");


        }
    }
}
