
namespace EscrituraArchivos
{
    partial class frmEscrituraArchivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtenerRutaArchivo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnCopiarArchivo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaArchivo);
            this.groupBox1.Controls.Add(this.btnObtenerRutaArchivo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1107, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONAR EL ARCHIVO A COPIAR";
            // 
            // btnObtenerRutaArchivo
            // 
            this.btnObtenerRutaArchivo.BackColor = System.Drawing.Color.DimGray;
            this.btnObtenerRutaArchivo.ForeColor = System.Drawing.Color.Transparent;
            this.btnObtenerRutaArchivo.Location = new System.Drawing.Point(86, 58);
            this.btnObtenerRutaArchivo.Name = "btnObtenerRutaArchivo";
            this.btnObtenerRutaArchivo.Size = new System.Drawing.Size(937, 50);
            this.btnObtenerRutaArchivo.TabIndex = 2;
            this.btnObtenerRutaArchivo.Text = "Obtener la ruta del archivo";
            this.btnObtenerRutaArchivo.UseVisualStyleBackColor = false;
            this.btnObtenerRutaArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(86, 138);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(937, 39);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // btnCopiarArchivo
            // 
            this.btnCopiarArchivo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCopiarArchivo.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarArchivo.ForeColor = System.Drawing.Color.Transparent;
            this.btnCopiarArchivo.Location = new System.Drawing.Point(406, 217);
            this.btnCopiarArchivo.Name = "btnCopiarArchivo";
            this.btnCopiarArchivo.Size = new System.Drawing.Size(339, 77);
            this.btnCopiarArchivo.TabIndex = 6;
            this.btnCopiarArchivo.Text = "Copiar archivo";
            this.btnCopiarArchivo.UseVisualStyleBackColor = false;
            this.btnCopiarArchivo.Click += new System.EventHandler(this.btnCopiarArchivo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(963, 325);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 70);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmEscrituraArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1163, 407);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCopiarArchivo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEscrituraArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnObtenerRutaArchivo;
        private System.Windows.Forms.Button btnCopiarArchivo;
        private System.Windows.Forms.Button btnSalir;
    }
}

