namespace ListasBasicas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblRazas = new System.Windows.Forms.Label();
            this.lstRazas = new System.Windows.Forms.ListBox();
            this.lblPrecioMayor = new System.Windows.Forms.Label();
            this.lstCiudadesxPaises = new System.Windows.Forms.ListBox();
            this.lblCiudadesxPais = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMadificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Black;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.ForeColor = System.Drawing.Color.White;
            this.lblSaludo.Location = new System.Drawing.Point(56, 27);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(305, 32);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Bienvenido a Coderhouse";
            // 
            // lblRazas
            // 
            this.lblRazas.AutoSize = true;
            this.lblRazas.BackColor = System.Drawing.Color.Black;
            this.lblRazas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRazas.ForeColor = System.Drawing.Color.White;
            this.lblRazas.Location = new System.Drawing.Point(56, 101);
            this.lblRazas.Name = "lblRazas";
            this.lblRazas.Size = new System.Drawing.Size(194, 32);
            this.lblRazas.TabIndex = 1;
            this.lblRazas.Text = "Razas de Perros";
            // 
            // lstRazas
            // 
            this.lstRazas.FormattingEnabled = true;
            this.lstRazas.ItemHeight = 15;
            this.lstRazas.Location = new System.Drawing.Point(70, 152);
            this.lstRazas.Name = "lstRazas";
            this.lstRazas.Size = new System.Drawing.Size(180, 139);
            this.lstRazas.TabIndex = 2;
            // 
            // lblPrecioMayor
            // 
            this.lblPrecioMayor.AutoSize = true;
            this.lblPrecioMayor.BackColor = System.Drawing.Color.Black;
            this.lblPrecioMayor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioMayor.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMayor.Location = new System.Drawing.Point(56, 334);
            this.lblPrecioMayor.Name = "lblPrecioMayor";
            this.lblPrecioMayor.Size = new System.Drawing.Size(182, 32);
            this.lblPrecioMayor.TabIndex = 3;
            this.lblPrecioMayor.Text = "Precio Mayor: ";
            // 
            // lstCiudadesxPaises
            // 
            this.lstCiudadesxPaises.FormattingEnabled = true;
            this.lstCiudadesxPaises.ItemHeight = 15;
            this.lstCiudadesxPaises.Location = new System.Drawing.Point(388, 161);
            this.lstCiudadesxPaises.Name = "lstCiudadesxPaises";
            this.lstCiudadesxPaises.Size = new System.Drawing.Size(180, 139);
            this.lstCiudadesxPaises.TabIndex = 5;
            // 
            // lblCiudadesxPais
            // 
            this.lblCiudadesxPais.AutoSize = true;
            this.lblCiudadesxPais.BackColor = System.Drawing.Color.Black;
            this.lblCiudadesxPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCiudadesxPais.ForeColor = System.Drawing.Color.White;
            this.lblCiudadesxPais.Location = new System.Drawing.Point(388, 110);
            this.lblCiudadesxPais.Name = "lblCiudadesxPais";
            this.lblCiudadesxPais.Size = new System.Drawing.Size(217, 32);
            this.lblCiudadesxPais.TabIndex = 4;
            this.lblCiudadesxPais.Text = "Ciudades por Pais";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(388, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 42);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(448, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Item";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMadificar
            // 
            this.btnMadificar.Location = new System.Drawing.Point(513, 71);
            this.btnMadificar.Name = "btnMadificar";
            this.btnMadificar.Size = new System.Drawing.Size(82, 42);
            this.btnMadificar.TabIndex = 8;
            this.btnMadificar.Text = "Modificar";
            this.btnMadificar.UseVisualStyleBackColor = true;
            this.btnMadificar.Click += new System.EventHandler(this.btnMadificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(601, 71);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 42);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 394);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMadificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstCiudadesxPaises);
            this.Controls.Add(this.lblCiudadesxPais);
            this.Controls.Add(this.lblPrecioMayor);
            this.Controls.Add(this.lstRazas);
            this.Controls.Add(this.lblRazas);
            this.Controls.Add(this.lblSaludo);
            this.Name = "Form1";
            this.Text = "Mi Primer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaludo;
        private Label lblRazas;
        private ListBox lstRazas;
        private Label lblPrecioMayor;
        private ListBox lstCiudadesxPaises;
        private Label lblCiudadesxPais;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnMadificar;
        private Button btnLimpiar;
    }
}