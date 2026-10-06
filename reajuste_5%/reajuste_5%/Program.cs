using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_5_
{//faça um algoritimo que
 //leia um valor qualquer
 //e imprima na tela com
 //um reajuste de 5%
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            
            double soma;

            Console.WriteLine("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());


            soma = valor + (valor * 0.05); 

            Console.WriteLine("Resultado: " + soma);



        }
    }
}
