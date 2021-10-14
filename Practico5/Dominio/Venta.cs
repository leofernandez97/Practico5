using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico5.Dominio
{
    class Venta
    {
        private short _id;
        private DateTime _fecha;
        private Vehiculo _vehiculo;

        /*
        clase contenedora (LISTA CON TODOS LOS OBJETOS)
         */

        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Vehiculo Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Fecha + " " + this.Vehiculo;
        }

        public Venta( short pId, DateTime pFecha, Vehiculo pVehiculo)
        {
            this.Id = pId;
            this.Fecha = pFecha;
            this.Vehiculo = pVehiculo;
        }
    }
}
