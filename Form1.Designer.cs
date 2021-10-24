
namespace CarritoCompras
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
            this.listCarritoCompras = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListProductos = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCarritoCompras
            // 
            this.listCarritoCompras.FormattingEnabled = true;
            this.listCarritoCompras.ItemHeight = 15;
            this.listCarritoCompras.Location = new System.Drawing.Point(62, 44);
            this.listCarritoCompras.Name = "listCarritoCompras";
            this.listCarritoCompras.Size = new System.Drawing.Size(202, 274);
            this.listCarritoCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(301, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListProductos
            // 
            this.btnListProductos.Location = new System.Drawing.Point(402, 124);
            this.btnListProductos.Name = "btnListProductos";
            this.btnListProductos.Size = new System.Drawing.Size(150, 23);
            this.btnListProductos.TabIndex = 2;
            this.btnListProductos.Text = "Calcular precio";
            this.btnListProductos.UseVisualStyleBackColor = true;
            this.btnListProductos.Click += new System.EventHandler(this.btnListProductos_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(301, 43);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(251, 23);
            this.cboProductos.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(301, 72);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 23);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnDescuento
            // 
            this.btnDescuento.Location = new System.Drawing.Point(301, 176);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(75, 23);
            this.btnDescuento.TabIndex = 5;
            this.btnDescuento.Text = "Codigo";
            this.btnDescuento.UseVisualStyleBackColor = true;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnDescuento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnListProductos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listCarritoCompras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCarritoCompras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnListProductos;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnDescuento;
    }
}

