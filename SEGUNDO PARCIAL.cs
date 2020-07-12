using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Random aleatorio = new Random();
            int votos;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0;
            double pr1 = 0, pr2 = 0, pr3 = 0, pr4 = 0;

            Console.WriteLine("Candidato 1: Dylan Ramos - Candidato presidencial \n PUPE (Partido unido por elección) \n Fundado el 12 / 9 / 1985");
            Console.WriteLine(" \n ");

            Console.WriteLine("Candidato 2: Danell Torres - Candidato presidencial \n GRD (Grupo revolucionario dominicano) \n Fundado el 24 / 1 / 1997");
            Console.WriteLine(" \n ");

            Console.WriteLine("Candidato 3: Darisleydi Santana - Candidato presidencial \n JUJSV (Jóvenes unidos jamás serán vencidos) \n Fundado el 21 / 2 / 2002");
            Console.WriteLine(" \n");

            Console.WriteLine("Candidato 4: Teodoro Figueroa - Candidato presidencial \n LPP (Lejos por unión política) \n Fundado el 25 / 7 / 1995");
            Console.WriteLine(" \n ");

            //se generan los 1000 votos aleatorios
            for (int i = 0; i < 1000; i++)
            {

                //se le asignan los votos a cada candidato y se les saca porcentaje
                votos = aleatorio.Next(1, 5);

                if (votos == 1)
                {
                    p1++;
                    
                }
                else if (votos == 2)
                {
                    p2++;
                    
                }
                else if (votos == 3)
                {
                    p3++;
                    
                }
                else
                {
                    p4++; 

                }
            }
            Console.WriteLine("             LOS RESULTADOS DE LAS ELECCIONES SON:   ");
            Console.WriteLine("        _______________________________________________  ");
            //en esta parte aqui ordeno los votos en descendente
            double[] orden = new double[] { p1, p2, p3, p4 };
            Array.Sort<double>(orden);
            Array.Reverse(orden);

            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine(" \n ");

                if (orden[i] == p1)
                {
                    pr1 = (p1 / 1000) * 100;
                    Console.WriteLine("CANDIDATO 1: Con un porcentaje de {0} % y una cantidad de votos de {1} ", pr1, orden[i]);
                }
                if (orden[i] == p2)
                {
                    pr2 = (p2 / 1000) * 100;
                    Console.WriteLine("CANDIDATO 2: Con un porcentaje de {0} % y una cantidad de votos de {1} ", pr2, orden[i]);
                }
                if (orden[i] == p3)
                {
                    pr3 = (p3 / 1000) * 100;
                    Console.WriteLine("CANDIDATO 3: Con un porcentaje de {0} % y una cantidad de votos de {1} ", pr3, orden[i]);
                }
                if (orden[i] == p4)
                {
                    pr4 = (p4 / 1000) * 100;
                    Console.WriteLine("CANDIDATO 4: Con un porcentaje de {0} % y una cantidad de votos de {1} ", pr4, orden[i]);
                }
            }

            Console.ReadKey();

            
        }
    }
}


                   
                    
