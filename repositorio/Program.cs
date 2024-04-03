using System;

namespace repositorio
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Calculadora básica");
            Console.WriteLine("------------------");

            string entrada, operacion;
            double op1 = 0, op2 = 0;
            string[] numeros;

            List<string> historial = new List<string>();

            do
            {
                Console.WriteLine("Introduzca operación: ");
                entrada = Console.ReadLine();

                if (entrada.Contains("+"))
                {
                    operacion = "+";
                    numeros = entrada.Split('+');
                    op1 = Convert.ToDouble(numeros[0]);
                    op2 = Convert.ToDouble(numeros[1]);
                    historial.Add(entrada);
                }
                else if (entrada.Contains("-"))
                {
                    operacion = "-";
                    numeros = entrada.Split("-");
                    op1 = Convert.ToDouble(numeros[0]);
                    op2 = Convert.ToDouble(numeros[1]);
                }
                else if (entrada.Contains("*"))
                {
                    historial.Add(entrada);
                    operacion = "*";
                    numeros = entrada.Split('*');
                    op1 = Convert.ToDouble(numeros[0]);
                    op2 = Convert.ToDouble(numeros[1]);
                    historial.Add(entrada);
                }
                else if (entrada.Contains("/"))
                {
                    historial.Add(entrada);
                    operacion = "/";
                    numeros = entrada.Split("/");
                    op1 = Convert.ToDouble(numeros[0]);
                    op2 = Convert.ToDouble(numeros[1]);
                }
                else
                {
                    operacion = entrada;
                }

                switch (operacion)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {op1 + op2}");
                        break;
                    case "-":
                        Console.WriteLine($"Resultado: {op1 - op2}");
                        break;
                    case "*":
                        Console.WriteLine($"Resultado: {op1 * op2}");
                        break;
                    case "/":
                        try
                        {
                            if(op2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            double aux = op1 / op2;
                            Console.WriteLine("Resultado: " + aux);
                        } catch (DivideByZeroException e) {
                            Console.WriteLine("Error: operación no válida: " + entrada);
                        }
                        break;
                    case "h":
                        imprimirHistorial(historial);
                        break;
                    case "q":
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;
                    default:
                        Console.WriteLine("Operación incorrecta");
                        break;
                }

            } while (!operacion.Equals("q"));

        }

        public static void imprimirHistorial(List<string> listaOperaciones)
        {
            Console.WriteLine("--Calculadora básica-");
            Console.WriteLine("---------------------");
            Console.WriteLine("Imprimiendo historial");
            foreach (string operacion in listaOperaciones)
            {
                Console.WriteLine(operacion);
            }
            Console.WriteLine("---------------------");
        }

    }

}