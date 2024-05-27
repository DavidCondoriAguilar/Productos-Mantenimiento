namespace ProyVentas_GUI
{
    partial class ProveedorMan03
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.mskRuc = new System.Windows.Forms.MaskedTextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRS = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtRepVen = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRepVentas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkEstado);
            this.grpDatos.Controls.Add(this.mskRuc);
            this.grpDatos.Controls.Add(this.cboDepartamento);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.lblCod);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtRS);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtRepVen);
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.txtRepVentas);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(397, 376);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(95, 320);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(62, 17);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Activo?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // mskRuc
            // 
            this.mskRuc.Location = new System.Drawing.Point(94, 155);
            this.mskRuc.Mask = "99999999999";
            this.mskRuc.Name = "mskRuc";
            this.mskRuc.Size = new System.Drawing.Size(100, 20);
            this.mskRuc.TabIndex = 7;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(94, 191);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(280, 21);
            this.cboDepartamento.TabIndex = 3;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(94, 223);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(280, 21);
            this.cboProvincia.TabIndex = 3;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(94, 255);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(280, 21);
            this.cboDistrito.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(319, 297);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(72, 24);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCod.Location = new System.Drawing.Point(93, 32);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(64, 20);
            this.lblCod.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Codigo:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "R.Social:";
            // 
            // txtRS
            // 
            this.txtRS.Location = new System.Drawing.Point(94, 67);
            this.txtRS.Name = "txtRS";
            this.txtRS.Size = new System.Drawing.Size(212, 20);
            this.txtRS.TabIndex = 0;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(94, 98);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(280, 20);
            this.txtDir.TabIndex = 1;
            // 
            // txtRepVen
            // 
            this.txtRepVen.Location = new System.Drawing.Point(94, 287);
            this.txtRepVen.Name = "txtRepVen";
            this.txtRepVen.Size = new System.Drawing.Size(192, 20);
            this.txtRepVen.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(94, 129);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(83, 20);
            this.txtTel.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Departamento:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Estado:";
            // 
            // txtRepVentas
            // 
            this.txtRepVentas.Location = new System.Drawing.Point(8, 290);
            this.txtRepVentas.Name = "txtRepVentas";
            this.txtRepVentas.Size = new System.Drawing.Size(80, 18);
            this.txtRepVentas.TabIndex = 3;
            this.txtRepVentas.Text = "Rep. Ventas:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "RUC:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Provincia:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 129);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Telefono:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 255);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Distrito:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            // 
            // ProveedorMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 397);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProveedorMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Proveedor";
            this.Load += new System.EventHandler(this.ProveedorMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.MaskedTextBox mskRuc;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDistrito;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label lblCod;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRS;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.TextBox txtRepVen;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label txtRepVentas;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
    }
}