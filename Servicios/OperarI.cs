using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal interface OperarI
    {
        
        /// <summary>
        /// Solicita al usuario dos operandos y los suma
        /// 171023-amd
        /// </summary>
        public void sumar();
        /// <summary>
        /// Solicita al usuario dos operandos y los resta
        /// 171023-amd
        /// </summary>
        public void restar();
        /// <summary>
        /// Solicita al usuario dos operandos y los multiplica
        /// 171023-amd
        /// </summary>

        public void multiplicar();
        /// <summary>
        /// Solicita al usuario dos operandos y los divide
        /// 171023-amd
        /// </summary>
        public void dividir();


    }
}

