using nrojllaExam.Servicios;
using nrojllaExam.Dto;

namespace nrojllaExam.Controlador
{
    /// <summary>
    /// Menu principal de stock de vajillas
    /// </summary>
    /// <autor>nvrv 041223</autor>
    internal class Program
    {
        /// <summary>
        /// Logica de la aplicacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<TenedoresDto> tenedores = new List<TenedoresDto>();

            IMenuInterfaz mi = new MenuImplementacion();
            ITenedoresInterfaz ti = new TenedoresImplementacion();

            int opcionSeleccionada;
            bool esCerrado = false;

            do
            {

                opcionSeleccionada = mi.MostrarMenu();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("El menu esta cerrado");
                        esCerrado=true;
                        break;
                    case 1:
                        ti.DarAltaTenedores(tenedores);

                        Console.WriteLine("Su resultado es: ");

                        foreach (TenedoresDto tenedoresDto in tenedores)
                        {     
                           Console.WriteLine(tenedoresDto.ToString());
                        }

                        break;
                    case 2:
                        ti.BorrarNumeroStockTenedores(tenedores);

                        foreach (TenedoresDto tenedoresDto in tenedores)
                        {
                            Console.WriteLine(tenedoresDto.ToString());
                        }

                        break;
                }


            } while (!esCerrado);

        }
    }
}