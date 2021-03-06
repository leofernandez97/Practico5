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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnMasCaros_Click(object sender, EventArgs e)
        {
            Dominio.Automotora unaAutomotora = new Dominio.Automotora();

            this.lstMasCaros.DataSource = unaAutomotora.VehiculosMasCaros();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenarPorMarca_Click(object sender, EventArgs e)
        {
            Dominio.Automotora unaAutomotora = new Dominio.Automotora();
            this.lstVehiculos.DataSource = unaAutomotora.VehiculosOrdenados();
        }
    }
}
