using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrojllaExam.Dto
{
    /// <summary>
    /// Datos de tenedores
    /// </summary>
    /// <autor>nvrv 041223</autor>
    internal class TenedoresDto
    {
        long id = 0000;

        string nombreT = "aaaaa";
        string descripcionT = "aaaaa";
        int cantidad = 0000;
        int codigoT = 0000;

        public long Id { get => id; set => id = value; }
        public string NombreT { get => nombreT; set => nombreT = value; }
        public string DescripcionT { get => descripcionT; set => descripcionT = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int CodigoT { get => codigoT; set => codigoT = value; }

        public TenedoresDto(long id, string nombreT, string descripcionT, int cantidad, int codigoT)
        {
            this.id = id;
            this.nombreT = nombreT;
            this.descripcionT = descripcionT;
            this.cantidad = cantidad;
            this.codigoT = codigoT;
        }

        public TenedoresDto()
        {
        }
    

        override
        public string ToString()
        {
            string objetoString = "Nombre: " + this.nombreT +
                                   "  Descripcion: " + this.descripcionT +
                                   "  Cantidad: " + this.cantidad +
                                   "  ID: " + this.id;

                return objetoString;
    
        }
     
    }
}
