using nrojllaExam.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrojllaExam.Servicios
{
    /// <summary>
    /// Biblioteca de metodos relacionado con tenedores
    /// </summary>
    /// <auto>nvrv 041223</auto>
    internal interface ITenedoresInterfaz
    {
        /// <summary>
        /// Metodo dar alta tenedor lista
        /// </summary>
        /// <param name="tenedores"></param>

        public void DarAltaTenedores(List<TenedoresDto> tenedores) {  }

        /// <summary>
        /// accion de borrar o eliminar un stock de tenedores
        /// </summary>
        /// <param name="tenedores"></param>
        public void BorrarNumeroStockTenedores(List<TenedoresDto> tenedores) { }
    }
}
