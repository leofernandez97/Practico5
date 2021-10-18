
namespace Practico5.Presentacion
{
    partial class frmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.btnMasCaros = new System.Windows.Forms.Button();
            this.btnOrdenarPorMarca = new System.Windows.Forms.Button();
            this.lstMasCaros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 16;
            this.lstVehiculos.Location = new System.Drawing.Point(50, 393);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(365, 260);
            this.lstVehiculos.TabIndex = 0;
            // 
            // btnMasCaros
            // 
            this.btnMasCaros.Location = new System.Drawing.Point(137, 69);
            this.btnMasCaros.Name = "btnMasCaros";
            this.btnMasCaros.Size = new System.Drawing.Size(159, 23);
            this.btnMasCaros.TabIndex = 1;
            this.btnMasCaros.Text = "Vehiculo mas caro";
            this.btnMasCaros.UseVisualStyleBackColor = true;
            this.btnMasCaros.Click += new System.EventHandler(this.btnMasCaros_Click);
            // 
            // btnOrdenarPorMarca
            // 
            this.btnOrdenarPorMarca.Location = new System.Drawing.Point(86, 364);
            this.btnOrdenarPorMarca.Name = "btnOrdenarPorMarca";
            this.btnOrdenarPorMarca.Size = new System.Drawing.Size(299, 23);
            this.btnOrdenarPorMarca.TabIndex = 2;
            this.btnOrdenarPorMarca.Text = "Vehiculos ordenados por marca";
            this.btnOrdenarPorMarca.UseVisualStyleBackColor = true;
            this.btnOrdenarPorMarca.Click += new System.EventHandler(this.btnOrdenarPorMarca_Click);
            // 
            // lstMasCaros
            // 
            this.lstMasCaros.FormattingEnabled = true;
            this.lstMasCaros.ItemHeight = 16;
            this.lstMasCaros.Location = new System.Drawing.Point(54, 98);
            this.lstMasCaros.Name = "lstMasCaros";
            this.lstMasCaros.Size = new System.Drawing.Size(365, 260);
            this.lstMasCaros.TabIndex = 4;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 702);
            this.Controls.Add(this.lstMasCaros);
            this.Controls.Add(this.btnOrdenarPorMarca);
            this.Controls.Add(this.btnMasCaros);
            this.Controls.Add(this.lstVehiculos);
            this.Name = "frmConsultas";
            this.Text = "frmConsultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button btnMasCaros;
        private System.Windows.Forms.Button btnOrdenarPorMarca;
        private System.Windows.Forms.ListBox lstMasCaros;
    }
}