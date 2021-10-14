using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Singleton
        private void Singleton(string pNombreForm)
        {
            bool encontre = false;
            foreach(Form unFrm in this.MdiChildren)
            {
                if (unFrm.Name.Equals(pNombreForm))
                {
                    encontre = true;
                    unFrm.Show();
                }
            }
            if (!encontre)
            {
                switch (pNombreForm)
                {
                    case "frmVehiculos":
                        Presentacion.frmVehiculos unFrmV = new Presentacion.frmVehiculos();
                        unFrmV.MdiParent = this;
                        unFrmV.Show();
                        break;

                    case "frmVentas":
                        Presentacion.frmVentas unFrmVe = new Presentacion.frmVentas();
                        unFrmVe.MdiParent = this;
                        unFrmVe.Show();
                        break;

                    case "frmConsultas":
                        Presentacion.frmConsultas unFrmC = new Presentacion.frmConsultas();
                        unFrmC.MdiParent = this;
                        unFrmC.Show();
                        break;

                }
            }

        }
        #endregion

        private void mnuVehiculos_Click(object sender, EventArgs e)
        {
            string nombrefrm = "frmVehiculos";
            Singleton(nombrefrm);
        }

        private void mnuVentas_Click(object sender, EventArgs e)
        {
            string nombrefrm = "frmVentas";
            this.Singleton(nombrefrm);
        }

        private void mnuConsultas_Click(object sender, EventArgs e)
        {
            string nombrefrm = "frmConsultas";
            this.Singleton(nombrefrm);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
