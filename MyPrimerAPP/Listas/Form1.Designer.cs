namespace Listas
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
            this.dgMayores = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMadificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMayores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMayores
            // 
            this.dgMayores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMayores.Location = new System.Drawing.Point(12, 60);
            this.dgMayores.Name = "dgMayores";
            this.dgMayores.RowTemplate.Height = 25;
            this.dgMayores.Size = new System.Drawing.Size(651, 292);
            this.dgMayores.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(580, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 42);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMadificar
            // 
            this.btnMadificar.Location = new System.Drawing.Point(339, 12);
            this.btnMadificar.Name = "btnMadificar";
            this.btnMadificar.Size = new System.Drawing.Size(82, 42);
            this.btnMadificar.TabIndex = 12;
            this.btnMadificar.Text = "Modificar";
            this.btnMadificar.UseVisualStyleBackColor = true;
            this.btnMadificar.Click += new System.EventHandler(this.btnMadificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(427, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(59, 42);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(493, 12);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(78, 42);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 364);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMadificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dgMayores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMayores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgMayores;
        private Button btnLimpiar;
        private Button btnMadificar;
        private Button btnBorrar;
        private Button btnOrdenar;
    }
}