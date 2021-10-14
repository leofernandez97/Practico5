using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico5.Dominio
{
    class Automotora
    {
        private static List<Vehiculo> Vehiculos = new List<Vehiculo>();
        private static List<Venta> Ventas = new List<Venta>();

        /*
        ABM Vehiculos
        ABM de Ventas (modificar no)

        Metodos para resolver consultas
         */

        #region ABM Vehiculo
        public Vehiculo buscarVehiculo(short pId)
        {
            foreach(Vehiculo unVehiculo in Vehiculos)
            {
                if (unVehiculo.Id == pId)
                {
                    return unVehiculo;
                }
            }
            return null;
        }
        public List<Vehiculo> ListaVehiculo()
        {
            return Vehiculos;
        }



        public bool alta(Vehiculo pVehiculo)
        {
            Vehiculo unVehiculo = this.buscarVehiculo(pVehiculo.Id);
            if (unVehiculo == null)
            {
                Vehiculos.Add(pVehiculo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool baja(short pId)
        {
            Vehiculo unVehiculo = this.buscarVehiculo(pId);
            if (unVehiculo != null)
            {
                Vehiculos.Remove(unVehiculo);
                return true;
            }
            else
            {
                return false;
            }
        }

        

        #endregion

        #region ABM Venta
        public Venta buscarVenta(short pId)
        {
            foreach(Venta unaVenta in Ventas)
            {
                if (unaVenta.Id.Equals(pId))
                {
                    return unaVenta;
                }
            }
            return null;
        }

        public bool altaVenta(Venta pVenta)
        {

            Venta unaVenta = this.buscarVenta(pVenta.Id);
            if (unaVenta == null)
            {
                Ventas.Add(pVenta);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool bajaVenta(Venta pVenta)
        {
            Venta unaVenta = this.buscarVenta(pVenta.Id);
            if(unaVenta != null)
            {
                Ventas.Remove(pVenta);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion


    }
}
