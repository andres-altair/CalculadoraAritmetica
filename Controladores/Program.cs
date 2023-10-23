using CalculadoraAritmetica;
using CalculadoraAritmetica.Servicios;

namespace CalculadoraAritmetica
{
    class program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperarI oI = new OperarC();
            mi.mostrarMenuYSeleccion();
            int opcionSeleccionada;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        oI.sumar();
                        break;
                    case 2:
                        oI.restar();
                        break;
                    case 3:
                        oI.multiplicar();
                        break;
                    case 4:
                        oI.dividir();
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción correcta");
                        break;

                }
            }
        }
    }
}

