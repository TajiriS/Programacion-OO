using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Votos1
    {
        static void Main(string[] args)
        {
            bool error = true;
            while (error == true)
            {
                error = false;
                Console.WriteLine("Numero de votos por partido 1");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de votos por partido 2");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de votos en blanco");
                double white = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de votos anulados");
                double wrongs = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero total de la poblacion de todas las edades");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("Porcentaje de poblacion mayor de edad");
                double eighteen = double.Parse(Console.ReadLine());
                double votos = a + b;
                double votostotal = a + b + white + wrongs;
                double thirty = (votos * 30) / 100;
                double potential = (p * eighteen) / 100;
                double abstention = p - potential;
                if(votostotal > potential || votostotal > p)
                {
                    Console.WriteLine("datos erroneos");
                    error = true;
                }
                else
                {

               


                if ((wrongs < thirty || votos > white) && abstention < votostotal)
                {
                    Console.WriteLine("Las votaciones fueron exitosas");
                    if (a > b)
                    {
                        Console.WriteLine("El ganador es el Partido 1");
                    }

                    if (b > a)
                    {
                        Console.WriteLine("El ganador es el Partido 2");
                    }
                    if(a == b)
                        {
                            Console.WriteLine("Empate");
                        }

                }
                else
                {
                    Console.WriteLine("Las votaciones deben realizarse nuevamente");
                }
                }

            }
        }
    }
}
