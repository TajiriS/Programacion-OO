using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
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
                double thirty = (p * 30) / 100;
            double ten = (votostotal * 10)/100;
            double diferencia = 0;

            if(a > b)
            {
                diferencia = a - b;
            }
            if(a < b)
            {
                diferencia = b - a;
            }
                
                    if((votostotal > p||diferencia < ten) && votostotal < thirty)
                {
                Console.WriteLine("Las votaciones deben repetirse");
                }

                    else
            {
                if(a < b)
                {
                    Console.WriteLine("El ganador es el partido 2");

                }
                if(a>b)
                {
                    Console.WriteLine("El ganador es el partido 1");

                }
               
            }
                
            
        }
    }
}
