using nrojllaExam.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrojllaExam.Servicios
{
    /// <summary>
    /// Logica de la interfaz de los metodos de tenedores
    /// </summary>
    internal class TenedoresImplementacion : ITenedoresInterfaz
    {
        IMenuInterfaz mi = new MenuImplementacion();
        public void BorrarNumeroStockTenedores(List<TenedoresDto> tenedores) 
        {   
            int pedirID = mi.PedirID();
            TenedoresDto tenedoresDtoBorrar = new TenedoresDto();
            
            foreach(TenedoresDto tenedoresDto in tenedores)
            {
                if (tenedoresDto.Id.Equals(pedirID))
                {
                    tenedoresDtoBorrar = tenedoresDto;
                    break;
                }
            }
            tenedores.Remove(tenedoresDtoBorrar); 

        }

        public void DarAltaTenedores(List<TenedoresDto> tenedores)
        {
            TenedoresDto tenedoresDto = CrearNuevoStockTenedores();

            tenedores.Add(tenedoresDto);
        }
        private TenedoresDto CrearNuevoStockTenedores()
        {
            TenedoresDto tenedores = new TenedoresDto();

            Console.WriteLine("Ingrese un nombre del stock para tenedores: ");
            tenedores.NombreT = Console.ReadLine();
            Console.WriteLine("Ingrese una descripcion para stock de tenedores: ");
            tenedores.DescripcionT = Console.ReadLine();
            Console.WriteLine("Ingrese una cantidad del stock tenedores: ");
            tenedores.Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un ID de stock tenedores: ");
            tenedores.Id = Convert.ToInt64(Console.ReadLine());
            

            return tenedores;
        }
    }
}
