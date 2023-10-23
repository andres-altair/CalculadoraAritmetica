using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal class OperarC : OperarI
    {
        private double pedirOperando()
        {
            double ope;
            Console.WriteLine("Indique un operando: ");
            ope = double.Parse(Console.ReadLine());
            return ope;
        }
        public void dividir()
        {
            double ope1 = pedirOperando();
            double ope2 = pedirOperando();
            double resultado = ope1 / ope2;
            Console.WriteLine(resultado);
        }

        public void multiplicar()
        {
            double ope1 = pedirOperando();
            double ope2 = pedirOperando();
            double resultado = ope1 * ope2;
            Console.WriteLine(resultado);
        }

        public void restar()
        {
            double ope1 = pedirOperando();
            double ope2 = pedirOperando();
            double resultado = ope1 - ope2 ;
            Console.WriteLine(resultado);
        }

        public void sumar()
        {
            double ope1 = pedirOperando();
            double ope2 = pedirOperando();
            double resultado = ope1 + ope2;
            Console.WriteLine(resultado);
        }
    }
}
    

