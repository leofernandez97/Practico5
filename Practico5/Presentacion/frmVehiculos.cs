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
    public partial class frmVehiculos : Form
    {

        private bool faltanDatos()
        {
            if (this.txtIdVehiculo.Text == "" || this.txtMarca.Text == "" || this.txtModelo.Text == "" || this.txtPrecio.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaVehiculo_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtIdVehiculo.Text);
                string marca = this.txtMarca.Text;
                string modelo = this.txtModelo.Text;
                short año = short.Parse(this.txtAnio.Text);
                double precio = double.Parse(this.txtPrecio.Text);

                Dominio.Vehiculo unVehiculo= new Dominio.Vehiculo(id, marca, modelo, año, precio);
                Dominio.Automotora unaAutomotora = new Dominio.Automotora();
                if (unaAutomotora.alta(unVehiculo))
                {
                    this.lblMensaje.Text = "Vehiculo ingresado con éxito!!";
                    this.Limpiar();
                    this.Listar();

                }
                else
                {
                    this.lblMensaje.Text = "Error";
                    
                }
            }
            else
            {
                this.lblMensaje.Text = "Faltan datos";
            }
         }

        private void Limpiar()
        {
            this.txtIdVehiculo.Clear();
            this.txtMarca.Clear();
            this.txtModelo.Clear();
            this.txtAnio.Clear();
            this.txtPrecio.Clear();
        }

        private void Listar()
        {
            Dominio.Automotora unaAutomotora = new Dominio.Automotora();
            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = unaAutomotora.ListaVehiculo();
        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBajaVehiculo_Click(object sender, EventArgs e)
        {
            short id = short.Parse(this.txtIdVehiculo.Text);
            Dominio.Automotora unaAutomotora = new Dominio.Automotora();
            this.lblMensaje.Text = "Vehiculo eliminado con exito";
            unaAutomotora.baja(id);
            this.Limpiar();
            this.Listar();
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            short id = short.Parse(this.txtIdVehiculo.Text);
            string marca = this.txtMarca.Text;
            string modelo = this.txtModelo.Text;
            short año = short.Parse(this.txtAnio.Text);
            double precio = double.Parse(this.txtPrecio.Text);

            Dominio.Automotora unaAutomotora = new Dominio.Automotora();

            unaAutomotora.modificar(id, marca, modelo, año, precio);
            this.lblMensaje.Text = "Vehiculo modificado con exito";
            this.Limpiar();
            this.Listar();
        }
    }
}
