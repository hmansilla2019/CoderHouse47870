namespace AppDesktop
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblEtiquetaNombre = new System.Windows.Forms.Label();
            this.txtValorNombre = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.lblEtiquetaRadio = new System.Windows.Forms.Label();
            this.lblResultadoArea = new System.Windows.Forms.Label();
            this.numRadio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRadio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(249, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(268, 54);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "BIENVENIDO";
            // 
            // lblEtiquetaNombre
            // 
            this.lblEtiquetaNombre.AutoSize = true;
            this.lblEtiquetaNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEtiquetaNombre.Location = new System.Drawing.Point(56, 110);
            this.lblEtiquetaNombre.Name = "lblEtiquetaNombre";
            this.lblEtiquetaNombre.Size = new System.Drawing.Size(187, 25);
            this.lblEtiquetaNombre.TabIndex = 1;
            this.lblEtiquetaNombre.Text = "Ingrese su Nombre:";
            // 
            // txtValorNombre
            // 
            this.txtValorNombre.Location = new System.Drawing.Point(249, 110);
            this.txtValorNombre.Name = "txtValorNombre";
            this.txtValorNombre.Size = new System.Drawing.Size(234, 23);
            this.txtValorNombre.TabIndex = 2;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(541, 105);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(142, 38);
            this.btnSaludar.TabIndex = 3;
            this.btnSaludar.Text = "SALUDAR";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(126, 164);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(580, 54);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "[Aqui aparecera su resultado]";
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(564, 290);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(142, 38);
            this.btnCalcularArea.TabIndex = 6;
            this.btnCalcularArea.Text = "CALCULAR AREA";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // lblEtiquetaRadio
            // 
            this.lblEtiquetaRadio.AutoSize = true;
            this.lblEtiquetaRadio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEtiquetaRadio.Location = new System.Drawing.Point(79, 295);
            this.lblEtiquetaRadio.Name = "lblEtiquetaRadio";
            this.lblEtiquetaRadio.Size = new System.Drawing.Size(278, 25);
            this.lblEtiquetaRadio.TabIndex = 5;
            this.lblEtiquetaRadio.Text = "Ingrese el Radio de un Circulo";
            // 
            // lblResultadoArea
            // 
            this.lblResultadoArea.AutoSize = true;
            this.lblResultadoArea.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoArea.ForeColor = System.Drawing.Color.White;
            this.lblResultadoArea.Location = new System.Drawing.Point(114, 352);
            this.lblResultadoArea.Name = "lblResultadoArea";
            this.lblResultadoArea.Size = new System.Drawing.Size(580, 54);
            this.lblResultadoArea.TabIndex = 7;
            this.lblResultadoArea.Text = "[Aqui aparecera su resultado]";
            // 
            // numRadio
            // 
            this.numRadio.Location = new System.Drawing.Point(363, 295);
            this.numRadio.Name = "numRadio";
            this.numRadio.Size = new System.Drawing.Size(120, 23);
            this.numRadio.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numRadio);
            this.Controls.Add(this.lblResultadoArea);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.lblEtiquetaRadio);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtValorNombre);
            this.Controls.Add(this.lblEtiquetaNombre);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBienvenida;
        private Label lblEtiquetaNombre;
        private TextBox txtValorNombre;
        private Button btnSaludar;
        private Label lblResultado;
        private Button btnCalcularArea;
        private Label lblEtiquetaRadio;
        private Label lblResultadoArea;
        private NumericUpDown numRadio;
    }
}