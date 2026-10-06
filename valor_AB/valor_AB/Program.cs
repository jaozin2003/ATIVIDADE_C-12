using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valor_AB
{
    internal class Program
    {
        static void Main(string[] args)

        {//faca um algoritimo que leia dois valores inteiros A e B, se os valores A e B forem iguais, devera somar os dois valores.//caso contraio devera multiplicar A por B.//ao final de qualquer dos calculos deve-se atribuir o resultado a uma variavel C e imprimir seu valor na tela.static void Main(string[] args)

            {

                int A, B, C;

                Console.Write("digite o valor de A: ");

                A = int.Parse(Console.ReadLine());

                Console.Write("digite o valor de B: ");

                B = int.Parse(Console.ReadLine());

                if (A == B)

                {

                    C = A * B;

                }

                else
                {

                    C = A * B;

                }

                Console.WriteLine("o valor de C é: " + C);

            }

        }

    }
}