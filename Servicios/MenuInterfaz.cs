using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios

{
    /// <summary>
    /// Interfaz que declara los métodos relacionados con el funcionamiento del menú
    /// 171023-amd
    /// </summary>

    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra las opciones del menú y eleccion  
        /// </summary>
        /// <returns>opción de menú </returns>
        public int mostrarMenuYSeleccion();

    }
}