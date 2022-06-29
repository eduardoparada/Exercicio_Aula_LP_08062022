using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula_LP_08062022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exercicio --> Qual a valor de tabuada? 
            //                  PREMISSAS
            //               Qual numero de inicio?
            //               Qual o numero final? - exemplo: começar uma tabuada do 10 e terminar no 37
            //               limites 0 - 100
            //               exibir todas as tabuadas! usar 'for', 'while' e 'do while'

            int numero, mult_inicial, mult_final;
            Console.WriteLine("Informa um numero para obter sua tabuada: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um multiplicador inicial para começar sua tabuada:");
            mult_inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um multiplicador final para finalizar sua tabuada: ");
            mult_final= int.Parse(Console.ReadLine());

            if (mult_inicial >= 0 && mult_inicial <= 100 && mult_inicial < mult_final && mult_final <=100)
            {
                
                // DO WHILE
                /*do
                {
                    Console.WriteLine (numero + "x" + mult_inicial + "=" + numero * mult_inicial);
                    mult_inicial++;
                }
                while (mult_inicial <= mult_final);*/


                // WHILE
                /*while (mult_inicial<=mult_final)
                {
                    Console.WriteLine (numero + "x" + mult_inicial + "=" + numero * mult_inicial);
                    mult_inicial++;
                }*/

                // FOR
                for (; mult_inicial <= mult_final; mult_inicial++)
                {
                    Console.WriteLine (numero + "x" + mult_inicial + "=" + numero * mult_inicial);
                    
                }
            }
            else
            {
                Console.WriteLine("Seus multiplicadores não atendem a aos limites e ordens necessárias para realizar os calculos!");

            }
            Console.ReadKey();
        }
    }
}
