using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5.Presentacion
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnAltaVenta_Click(object sender, EventArgs e)
        {
            short id = short.Parse(this.txtId.Text);
            string modelo = this.txtModelo.Text;
            short anio = short.Parse(this.txtAnio.Text);



            
            Dominio.Automotora unaAutomotora = new Dominio.Automotora();
            Dominio.Venta unaVenta = new Dominio.Venta(id, DateTime.Now.Date, unaAutomotora.buscarVehiculo(id));
            unaAutomotora.buscarVehiculo(id);

            unaAutomotora.altaVenta(unaVenta);
            this.Limpiar();
            this.Listar();
        }

        private void Listar()
        {
            Dominio.Automotora unaAutomotora = new Dominio.Automotora();

            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = unaAutomotora.ListaVehiculo();

            this.lstVentas.DataSource = null;
            this.lstVentas.DataSource = unaAutomotora.ListaVenta();
        }

        private void Limpiar()
        {
            this.txtAnio.Clear();
            this.txtId.Clear();
            this.txtModelo.Clear();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
