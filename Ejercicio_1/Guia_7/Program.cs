using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7
{
    internal class Program
    {
        #region Analisis
        /*La idea es ubicar un puesto de control
         * que verificará si el vehículo a ingresar tiene el ticket que valide su acceso, y sino lo tiene el encargado emitirá el ticket.

        El cobro se realiza en base al tipo de vehículo que el turista con quiera ingresar al predio.Puede que declare más de uno del mismo tipo
        sin vehiculo 100, moto 800 auto 1000, camioneta 1500, bugy 5000, nautico 1200

        valides del tiqueck, max 10 dias. tabla de costo
        dias-porcentaje
        1-100
        2-120
        3-220
        4-320
        5 a 10 - 380

        se aplica iva del 21% 
        se aplica impusto ecologico 15%

        mostrar detalles de todo en el ticket
        deje la posibilidad de informar cuanto recaudo cada puesto de control y el ticket con mayor costo.


            */
#endregion



        #region Mis variables


        #endregion


        #region Mis Metodos

        static void mostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Menu Principal \n \r 1- Verificar Acceso \n \r 2- Imprimir Recaudacion \n \r 3- Mostrar cantidad de Accesos \n \r otro- Salir");
        }
        static void mostrarMenuRegistro()
        {
            Console.Clear();
            Console.WriteLine("Menu Registro \n\r 1- Validar Ticket \n\r 2- Generar Ticket \n\r 0- Menu Principal");
        }
            static void verificarOpcion(int opcion)
        {
            switch (opcion) {
                case 1: //verificar acceso
                    break;
                case 2://Imprimir Recaudacion
                    break;
                case 3: //Mostrar cantidad de accesos
                    break;
                default: //Salir --> fin del sistema
                    break;
            }
        }

        static void registrarAcceso()
        {
            do// verificamos que elija opcion correcta
            {
                
                mostrarMenuRegistro();


            }while (true);


        }

        #endregion





static void Main(string[] args)
{

}
}
}
