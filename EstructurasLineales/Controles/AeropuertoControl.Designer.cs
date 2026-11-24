#nullable disable
namespace EstructurasLineales.Controles
{
    partial class AeropuertoControl
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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
            this.grpEspera = new System.Windows.Forms.GroupBox();
            this.lvEspera = new System.Windows.Forms.ListView();
            this.colOrden = new System.Windows.Forms.ColumnHeader();
            this.colCodigo = new System.Windows.Forms.ColumnHeader();
            this.colTipo = new System.Windows.Forms.ColumnHeader();
            this.colPrioridad = new System.Windows.Forms.ColumnHeader();
            this.colSolicitud = new System.Windows.Forms.ColumnHeader();
            this.grpDespacho = new System.Windows.Forms.GroupBox();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPista = new System.Windows.Forms.Label();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.grpSolicitud = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnAleatorios = new System.Windows.Forms.Button();
            this.grpEspera.SuspendLayout();
            this.grpDespacho.SuspendLayout();
            this.grpSolicitud.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEspera
            // 
            this.grpEspera.Text = "Cola de espera (prioridad)";
            this.grpEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEspera.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lvEspera
            // 
            this.lvEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEspera.FullRowSelect = true;
            this.lvEspera.GridLines = true;
            this.lvEspera.View = System.Windows.Forms.View.Details;
            this.lvEspera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvEspera.HideSelection = false;
            this.lvEspera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.colOrden, this.colCodigo, this.colTipo, this.colPrioridad, this.colSolicitud});
            // 
            // colOrden
            // 
            this.colOrden.Text = "Turno";
            this.colOrden.Width = 60;
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "Vuelo";
            this.colCodigo.Width = 100;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.Width = 110;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Text = "Prioridad";
            this.colPrioridad.Width = 80;
            // 
            // colSolicitud
            // 
            this.colSolicitud.Text = "Solicitó pista";
            this.colSolicitud.Width = 110;
            // 
            // grpDespacho
            // 
            this.grpDespacho.Text = "Torre de control";
            this.grpDespacho.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpDespacho.Size = new System.Drawing.Size(390, 100);
            this.grpDespacho.Padding = new System.Windows.Forms.Padding(8);
            // 
            // btnDespachar
            // 
            this.btnDespachar.Location = new System.Drawing.Point(15, 30);
            this.btnDespachar.Size = new System.Drawing.Size(355, 46);
            this.btnDespachar.Text = "Despachar siguiente vuelo";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(15, 84);
            this.btnSiguiente.Size = new System.Drawing.Size(355, 32);
            this.btnSiguiente.Text = "Ver siguiente (Peek)";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPista
            // 
            this.lblPista.Location = new System.Drawing.Point(15, 128);
            this.lblPista.Size = new System.Drawing.Size(355, 70);
            this.lblPista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPista.Text = "Pista libre";
            this.lblPista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Location = new System.Drawing.Point(15, 212);
            this.lblHistorialTitulo.Text = "Historial de despachos (pila: el último arriba):";
            // 
            // lstHistorial
            // 
            this.lstHistorial.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.IntegralHeight = false;
            this.lstHistorial.Location = new System.Drawing.Point(15, 240);
            this.lstHistorial.Size = new System.Drawing.Size(355, 260);
            this.lstHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(15, 508);
            this.btnReiniciar.Size = new System.Drawing.Size(355, 30);
            this.btnReiniciar.Text = "Reiniciar simulación";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // grpSolicitud
            // 
            this.grpSolicitud.Text = "Nueva solicitud de pista";
            this.grpSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSolicitud.Size = new System.Drawing.Size(100, 100);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 36);
            this.lblCodigo.Text = "Vuelo (opcional):";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 33);
            this.txtCodigo.Size = new System.Drawing.Size(110, 27);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(265, 36);
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(315, 33);
            this.cboTipo.Size = new System.Drawing.Size(140, 28);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(470, 30);
            this.btnSolicitar.Size = new System.Drawing.Size(150, 30);
            this.btnSolicitar.Text = "Solicitar pista";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnAleatorios
            // 
            this.btnAleatorios.Location = new System.Drawing.Point(630, 30);
            this.btnAleatorios.Size = new System.Drawing.Size(190, 30);
            this.btnAleatorios.Text = "Generar 5 aleatorios";
            this.btnAleatorios.UseVisualStyleBackColor = true;
            this.btnAleatorios.Click += new System.EventHandler(this.btnAleatorios_Click);
            // 
            // AeropuertoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AeropuertoControl";
            this.Size = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.grpEspera);
            this.Controls.Add(this.grpDespacho);
            this.Controls.Add(this.grpSolicitud);
            this.grpEspera.Controls.Add(this.lvEspera);
            this.grpDespacho.Controls.Add(this.btnDespachar);
            this.grpDespacho.Controls.Add(this.btnSiguiente);
            this.grpDespacho.Controls.Add(this.lblPista);
            this.grpDespacho.Controls.Add(this.lblHistorialTitulo);
            this.grpDespacho.Controls.Add(this.lstHistorial);
            this.grpDespacho.Controls.Add(this.btnReiniciar);
            this.grpSolicitud.Controls.Add(this.lblCodigo);
            this.grpSolicitud.Controls.Add(this.txtCodigo);
            this.grpSolicitud.Controls.Add(this.lblTipo);
            this.grpSolicitud.Controls.Add(this.cboTipo);
            this.grpSolicitud.Controls.Add(this.btnSolicitar);
            this.grpSolicitud.Controls.Add(this.btnAleatorios);
            this.grpSolicitud.ResumeLayout(false);
            this.grpDespacho.ResumeLayout(false);
            this.grpEspera.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpEspera;
        private System.Windows.Forms.ListView lvEspera;
        private System.Windows.Forms.ColumnHeader colOrden;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colPrioridad;
        private System.Windows.Forms.ColumnHeader colSolicitud;
        private System.Windows.Forms.GroupBox grpDespacho;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.GroupBox grpSolicitud;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnAleatorios;
    }
}
