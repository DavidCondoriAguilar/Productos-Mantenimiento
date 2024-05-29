namespace ProyVentas_GUI
{
    partial class ProductoMan02
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
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboCategoria = new ComboBox();
            label6 = new Label();
            cboUM = new ComboBox();
            chkActivo = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            txtPrecio = new TextBox();
            txtStkAct = new TextBox();
            txtStkMin = new TextBox();
            groupBox1 = new GroupBox();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(124, 47);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(389, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 87);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio actual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 90);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Stock actual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 90);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Stock mínimo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 129);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(124, 129);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(256, 23);
            cboCategoria.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 173);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 10;
            label6.Text = "U. Medida:";
            // 
            // cboUM
            // 
            cboUM.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUM.FormattingEnabled = true;
            cboUM.Location = new Point(124, 170);
            cboUM.Name = "cboUM";
            cboUM.Size = new Size(256, 23);
            cboUM.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(237, 228);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(352, 253);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(490, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 84);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(93, 23);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtStkAct
            // 
            txtStkAct.Location = new Point(343, 87);
            txtStkAct.Name = "txtStkAct";
            txtStkAct.Size = new Size(62, 23);
            txtStkAct.TabIndex = 2;
            txtStkAct.TextAlign = HorizontalAlignment.Right;
            txtStkAct.KeyPress += txtStkAct_KeyPress;
            // 
            // txtStkMin
            // 
            txtStkMin.Location = new Point(535, 87);
            txtStkMin.Name = "txtStkMin";
            txtStkMin.Size = new Size(62, 23);
            txtStkMin.TabIndex = 3;
            txtStkMin.TextAlign = HorizontalAlignment.Right;
            txtStkMin.KeyPress += txtStkAct_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optImportado);
            groupBox1.Controls.Add(optNacional);
            groupBox1.Location = new Point(37, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 100);
            groupBox1.TabIndex = 12;
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
            // ProductoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 349);
            Controls.Add(groupBox1);
            Controls.Add(txtStkMin);
            Controls.Add(txtStkAct);
            Controls.Add(txtPrecio);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo producto";
            Load += ProductoMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboCategoria;
        private Label label6;
        private ComboBox cboUM;
        private CheckBox chkActivo;
        private Button btnGrabar;
        private Button btnCancelar;
        private TextBox txtPrecio;
        private TextBox txtStkAct;
        private TextBox txtStkMin;
        private GroupBox groupBox1;
        private RadioButton optImportado;
        private RadioButton optNacional;
    }
}