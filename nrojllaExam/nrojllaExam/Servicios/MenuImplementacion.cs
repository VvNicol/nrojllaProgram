using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrojllaExam.Servicios
{
    /// <summary>
    /// Menu de implementacion de menu interfaz
    /// </summary>
    internal class MenuImplementacion : IMenuInterfaz
    {
        public int MostrarMenu()
        {
            int Elegir;

            Console.WriteLine("....................");
            Console.WriteLine("Menu Stock de vajillas");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Dar alta elemento");
            Console.WriteLine("2.Eliminar elemento");
            Console.WriteLine("....................");

            Elegir = Convert.ToInt32(Console.ReadLine());
            return Elegir;
        }

        public int PedirID()
        {
          
           Console.WriteLine("Ingrese numero de ID (INT)");
           int pedirID = Convert.ToInt32(Console.ReadLine());
           return pedirID;
            
        }
    }
}
