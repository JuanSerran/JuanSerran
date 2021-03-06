namespace CapaPresentacion
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstvLista = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlTitulo.Controls.Add(this.pnlOpciones);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 51);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pbCerrar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(730, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(70, 51);
            this.pnlOpciones.TabIndex = 1;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(29, 0);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lstvLista
            // 
            this.lstvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNombre,
            this.colApellido1,
            this.colApellido2});
            this.lstvLista.FullRowSelect = true;
            this.lstvLista.GridLines = true;
            this.lstvLista.HideSelection = false;
            this.lstvLista.Location = new System.Drawing.Point(13, 156);
            this.lstvLista.MultiSelect = false;
            this.lstvLista.Name = "lstvLista";
            this.lstvLista.Size = new System.Drawing.Size(775, 282);
            this.lstvLista.TabIndex = 2;
            this.lstvLista.UseCompatibleStateImageBehavior = false;
            this.lstvLista.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 100;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 150;
            // 
            // colApellido1
            // 
            this.colApellido1.Text = "Primer Apellido";
            this.colApellido1.Width = 150;
            // 
            // colApellido2
            // 
            this.colApellido2.Text = "Segundo Apellido";
            this.colApellido2.Width = 150;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(13, 98);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(438, 20);
            this.txtBusqueda.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Blue;
            this.btnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Location = new System.Drawing.Point(457, 81);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 37);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lstvLista);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListView lstvLista;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido1;
        private System.Windows.Forms.ColumnHeader colApellido2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnNuevo;
    }
}