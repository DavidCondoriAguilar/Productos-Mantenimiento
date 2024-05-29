namespace ProyWinC_Sem04
{
    partial class frmExecuteScalar
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
            this.btnObtenerMaximoPrecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskAño = new System.Windows.Forms.MaskedTextBox();
            this.btnObtenerVentaAnual = new System.Windows.Forms.Button();
            this.lblVentaAnual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObtenerMaximoPrecio
            // 
            this.btnObtenerMaximoPrecio.Location = new System.Drawing.Point(101, 32);
            this.btnObtenerMaximoPrecio.Name = "btnObtenerMaximoPrecio";
            this.btnObtenerMaximoPrecio.Size = new System.Drawing.Size(156, 31);
            this.btnObtenerMaximoPrecio.TabIndex = 0;
            this.btnObtenerMaximoPrecio.Text = "Obtener Maximo Precio";
            this.btnObtenerMaximoPrecio.UseVisualStyleBackColor = true;
            this.btnObtenerMaximoPrecio.Click += new System.EventHandler(this.btnObtenerMaximoPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año:";
            // 
            // mskAño
            // 
            this.mskAño.Location = new System.Drawing.Point(182, 85);
            this.mskAño.Mask = "9999";
            this.mskAño.Name = "mskAño";
            this.mskAño.Size = new System.Drawing.Size(75, 23);
            this.mskAño.TabIndex = 2;
            // 
            // btnObtenerVentaAnual
            // 
            this.btnObtenerVentaAnual.Location = new System.Drawing.Point(283, 85);
            this.btnObtenerVentaAnual.Name = "btnObtenerVentaAnual";
            this.btnObtenerVentaAnual.Size = new System.Drawing.Size(151, 26);
            this.btnObtenerVentaAnual.TabIndex = 3;
            this.btnObtenerVentaAnual.Text = "Obtener Venta Anual";
            this.btnObtenerVentaAnual.UseVisualStyleBackColor = true;
            this.btnObtenerVentaAnual.Click += new System.EventHandler(this.btnObtenerVentaAnual_Click);
            // 
            // lblVentaAnual
            // 
            this.lblVentaAnual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVentaAnual.Location = new System.Drawing.Point(182, 130);
            this.lblVentaAnual.Name = "lblVentaAnual";
            this.lblVentaAnual.Size = new System.Drawing.Size(100, 23);
            this.lblVentaAnual.TabIndex = 4;
            this.lblVentaAnual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // frmExecuteScalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 202);
            this.Controls.Add(this.lblVentaAnual);
            this.Controls.Add(this.btnObtenerVentaAnual);
            this.Controls.Add(this.mskAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerMaximoPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExecuteScalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo ExecuteScalar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObtenerMaximoPrecio;
        private Label label1;
        private MaskedTextBox mskAño;
        private Button btnObtenerVentaAnual;
        private Label lblVentaAnual;
        private Label label2;
    }
}