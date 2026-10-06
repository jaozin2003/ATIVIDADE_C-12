using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_e_F
{
    internal class Program
    {

        static void Main(string[] args)

        {

            double valor, reajuste, resultado;


            Console.Write("Digite um valor: R$ ");

            valor = double.Parse(Console.ReadLine());


            reajuste = valor * 0.05;

            resultado = valor + reajuste;


            Console.WriteLine("Valor com reajuste de 5%: R$ " + resultado.ToString("F2"));

        }

    }

}