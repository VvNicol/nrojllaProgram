using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrojllaExam.Servicios
{
    /// <summary>
    /// Biblioteca de interfaz del menu
    /// </summary>
    /// <autor>nvrv 041223</autor>
    internal interface IMenuInterfaz
    {
        /// <summary>
        /// Interfaz del menu principal
        /// </summary>
        /// <returns>opcion a elegir</returns>
        public int MostrarMenu();

        /// <summary>
        /// pide un numero para identificacion
        /// </summary>
        /// <returns>string</returns>
        public int PedirID();
    }
}
