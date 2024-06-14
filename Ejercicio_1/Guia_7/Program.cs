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
        //limpia pantalla
        static void limpiarPantalla()
        {
            Console.Clear();
        }
        //Menu principal
        static void mostrarMenuPrincipal()
        {
            limpiarPantalla();
            Console.WriteLine("Menu Principal \n \r 1- Verificar Acceso \n \r 2- Imprimir Recaudacion \n \r 3- Mostrar cantidad de Accesos \n \r otro- Salir");
        }
        //Menu Registro
        static void mostrarMenuRegistro()
        {
            limpiarPantalla();
            Console.WriteLine("Menu Registro \n\r 1- Validar Ticket \n\r 2- Generar Ticket \n\r 0- Menu Principal");
        }
        
        //Valida ticket (PROTOTIPO)
        static bool validatick(int numTicket)
        {
            if (numTicket > 0) { return true; }

            return false;    
            
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
            int op;
            do// verificamos que elija opcion correcta
            {
                
                mostrarMenuRegistro();//"Menu Registro \n\r 1- Validar Ticket \n\r 2- Generar Ticket \n\r 0- Menu Principal"
                op =int.Parse(Console.ReadLine());
                if(op >= 0 && op < 3)
                {
                    break;
                }

                Console.WriteLine("Por favor, ingrese una opcion valida ");


            }while (true);

            while(true)
            {
                switch (op)
                {
                    case 1:
                        //validamos ticket
                        Console.WriteLine("Ingrese numero de tickte");
                        int numTicket = int.Parse(Console.ReadLine());
                        if (validatick(numTicket))
                        {
                            Console.WriteLine("Ticket valido, permitir acceso");
                        }
                        else
                        {
                            Console.WriteLine("Tick NO valido, Generar ticket");
                        }
                        Console.ReadKey();
                        limpiarPantalla();

                        break;
                    case 2:
                        //generamos nuevo tickt
                        break;
                    case 0:
                        return;
                        //break; //volvemos al menu principal
                }


            }
        }

        #endregion





static void Main(string[] args)
{

}
}
}
