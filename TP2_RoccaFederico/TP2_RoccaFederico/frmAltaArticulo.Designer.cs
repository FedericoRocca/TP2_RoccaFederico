namespace TP2_RoccaFederico
{
    partial class frmAltaArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbImagen = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.gpbAltaArticulo = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.gpbAltaArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(73, 19);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(215, 20);
            this.txbCodigo.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(73, 45);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(215, 20);
            this.txbNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(73, 71);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(215, 20);
            this.txbDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(4, 74);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txbImagen
            // 
            this.txbImagen.Location = new System.Drawing.Point(73, 151);
            this.txbImagen.Name = "txbImagen";
            this.txbImagen.Size = new System.Drawing.Size(215, 20);
            this.txbImagen.TabIndex = 6;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(25, 154);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(42, 13);
            this.lblImagen.TabIndex = 6;
            this.lblImagen.Text = "Imagen";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(30, 180);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 127);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 100);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(73, 97);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(215, 21);
            this.cmbMarca.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(73, 124);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(215, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // gpbAltaArticulo
            // 
            this.gpbAltaArticulo.Controls.Add(this.nudPrecio);
            this.gpbAltaArticulo.Controls.Add(this.btnCancelar);
            this.gpbAltaArticulo.Controls.Add(this.txbCodigo);
            this.gpbAltaArticulo.Controls.Add(this.btnGuardar);
            this.gpbAltaArticulo.Controls.Add(this.lblCodigo);
            this.gpbAltaArticulo.Controls.Add(this.lblNombre);
            this.gpbAltaArticulo.Controls.Add(this.cmbCategoria);
            this.gpbAltaArticulo.Controls.Add(this.txbNombre);
            this.gpbAltaArticulo.Controls.Add(this.cmbMarca);
            this.gpbAltaArticulo.Controls.Add(this.lblDescripcion);
            this.gpbAltaArticulo.Controls.Add(this.lblCategoria);
            this.gpbAltaArticulo.Controls.Add(this.txbDescripcion);
            this.gpbAltaArticulo.Controls.Add(this.lblMarca);
            this.gpbAltaArticulo.Controls.Add(this.lblImagen);
            this.gpbAltaArticulo.Controls.Add(this.txbImagen);
            this.gpbAltaArticulo.Controls.Add(this.lblPrecio);
            this.gpbAltaArticulo.Location = new System.Drawing.Point(12, 12);
            this.gpbAltaArticulo.Name = "gpbAltaArticulo";
            this.gpbAltaArticulo.Size = new System.Drawing.Size(294, 234);
            this.gpbAltaArticulo.TabIndex = 14;
            this.gpbAltaArticulo.TabStop = false;
            this.gpbAltaArticulo.Text = "Datos del artículo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(153, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(73, 178);
            this.nudPrecio.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(215, 20);
            this.nudPrecio.TabIndex = 12;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecio.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmAltaArticulo
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(313, 252);
            this.Controls.Add(this.gpbAltaArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaArticulo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Alta artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            this.gpbAltaArticulo.ResumeLayout(false);
            this.gpbAltaArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox gpbAltaArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudPrecio;
    }
}