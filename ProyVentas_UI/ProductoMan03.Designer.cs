namespace ProyVentas_GUI
{
    partial class ProductoMan03
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkActivo = new CheckBox();
            cboUM = new ComboBox();
            cboCategoria = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            lblCodigo = new Label();
            txtStkMin = new TextBox();
            txtStkAct = new TextBox();
            txtPrecio = new TextBox();
            groupBox1 = new GroupBox();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(498, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(360, 269);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(248, 244);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboUM
            // 
            cboUM.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUM.FormattingEnabled = true;
            cboUM.Location = new Point(132, 186);
            cboUM.Name = "cboUM";
            cboUM.Size = new Size(256, 23);
            cboUM.TabIndex = 5;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(132, 145);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(256, 23);
            cboCategoria.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 106);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Stock mínimo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 106);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 6;
            label3.Text = "Stock actual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 189);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 12;
            label6.Text = "U. Medida:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(132, 63);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(389, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 145);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 103);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio actual:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Descripcion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 21);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 0;
            label7.Text = "Código:";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(132, 21);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 1;
            // 
            // txtStkMin
            // 
            txtStkMin.Location = new Point(543, 106);
            txtStkMin.Name = "txtStkMin";
            txtStkMin.Size = new Size(62, 23);
            txtStkMin.TabIndex = 3;
            txtStkMin.TextAlign = HorizontalAlignment.Right;
            txtStkMin.KeyPress += txtStkAct_KeyPress;
            // 
            // txtStkAct
            // 
            txtStkAct.Location = new Point(351, 106);
            txtStkAct.Name = "txtStkAct";
            txtStkAct.Size = new Size(62, 23);
            txtStkAct.TabIndex = 2;
            txtStkAct.TextAlign = HorizontalAlignment.Right;
            txtStkAct.KeyPress += txtStkAct_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(132, 103);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(93, 23);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optImportado);
            groupBox1.Controls.Add(optNacional);
            groupBox1.Location = new Point(45, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Origen";
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(29, 64);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(81, 19);
            optImportado.TabIndex = 1;
            optImportado.Text = "Importado";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Checked = true;
            optNacional.Location = new Point(29, 27);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(72, 19);
            optNacional.TabIndex = 0;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // ProductoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 404);
            Controls.Add(groupBox1);
            Controls.Add(txtStkMin);
            Controls.Add(txtStkAct);
            Controls.Add(txtPrecio);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkActivo);
            Controls.Add(cboUM);
            Controls.Add(cboCategoria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar producto";
            Load += ProductoMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private CheckBox chkActivo;
        private ComboBox cboUM;
        private ComboBox cboCategoria;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label lblCodigo;
        private TextBox txtStkMin;
        private TextBox txtStkAct;
        private TextBox txtPrecio;
        private GroupBox groupBox1;
        private RadioButton optImportado;
        private RadioButton optNacional;
    }
}