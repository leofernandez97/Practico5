using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico5.Dominio
{
    class Vehiculo
    {
        private short _id;
        private string _marca;
        private string _modelo;
        private short _año;
        private short _stock;
        private double _precio;

        /*
        public override toString()
        metodo creador public Vehiculo()
        alguna consulta puede ir aca
         */
        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public short Anio
        {
            get { return _año; }
            set { _año = value; }
        }

        public short Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Vehiculo(short pId, string pMarca, string pModelo, short pAnio, double pPrecio)
        {
            this.Id = pId;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Anio = pAnio;
            this.Precio = pPrecio;
        }

        public override string ToString()
        {
            return this.Id + " " + this.Marca + " " + this.Modelo + " " + this.Anio + " "+this.Stock+ " " + this.Precio;
        }

        
    }
}
