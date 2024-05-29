namespace ProyWinC_Sem04
{
    partial class frmDemoConexiones
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
            this.grpConexiones = new System.Windows.Forms.GroupBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpConexiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConexiones
            // 
            this.grpConexiones.Controls.Add(this.btnCerrar);
            this.grpConexiones.Controls.Add(this.btnAbrir);
            this.grpConexiones.Location = new System.Drawing.Point(79, 27);
            this.grpConexiones.Name = "grpConexiones";
            this.grpConexiones.Size = new System.Drawing.Size(429, 118);
            this.grpConexiones.TabIndex = 0;
            this.grpConexiones.TabStop = false;
            this.grpConexiones.Text = "Manejo de Conexiones";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(77, 51);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(102, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir conexion";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(232, 51);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar conexion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmDemoConexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 191);
            this.Controls.Add(this.grpConexiones);
            this.Name = "frmDemoConexiones";
            this.Text = "Demo Conexiones";
            this.grpConexiones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpConexiones;
        private Button btnCerrar;
        private Button btnAbrir;
    }
}