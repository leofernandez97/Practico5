using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Dominio.Automotora unaAutomotora = new Dominio.Automotora();
            Dominio.Vehiculo vehiculo1 = new Dominio.Vehiculo(1, "Citroen", "C4", 2011, 2500);
            unaAutomotora.alta(vehiculo1);
            Dominio.Vehiculo vehiculo2 = new Dominio.Vehiculo(2, "Honda", "Civic", 2019, 4000);
            unaAutomotora.alta(vehiculo2);
            Dominio.Vehiculo vehiculo3 = new Dominio.Vehiculo(3, "Citroen", "Cactus", 2010, 4500);
            unaAutomotora.alta(vehiculo3);
            Dominio.Vehiculo vehiculo4 = new Dominio.Vehiculo(4, "Peugeot", "308", 2018, 3500);
            unaAutomotora.alta(vehiculo4);
            Dominio.Vehiculo vehiculo5 = new Dominio.Vehiculo(5, "Citroen", "C3", 2010, 4500);
            unaAutomotora.alta(vehiculo5);

            Application.Run(new Form1());
        }
    }
}
