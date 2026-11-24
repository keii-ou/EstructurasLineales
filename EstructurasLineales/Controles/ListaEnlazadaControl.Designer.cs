#nullable disable
namespace EstructurasLineales.Controles
{
    partial class ListaEnlazadaControl
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
            this.lstNodos = new System.Windows.Forms.ListBox();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.lblCadena = new System.Windows.Forms.Label();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.nudIndice = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminarEn = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNodos
            // 
            this.lstNodos.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstNodos.FormattingEnabled = true;
            this.lstNodos.IntegralHeight = false;
            this.lstNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // txtBitacora
            // 
            this.txtBitacora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBitacora.Multiline = true;
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtBitacora.BackColor = System.Drawing.SystemColors.Window;
            this.txtBitacora.Size = new System.Drawing.Size(100, 130);
            // 
            // lblCadena
            // 
            this.lblCadena.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCadena.Size = new System.Drawing.Size(100, 100);
            this.lblCadena.Font = new System.Drawing.Font("Consolas", 13F);
            this.lblCadena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCadena.Padding = new System.Windows.Forms.Padding(8);
            this.lblCadena.Text = "";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Text = "Operaciones sobre la lista enlazada simple";
            this.grpOperaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpOperaciones.Size = new System.Drawing.Size(340, 100);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(15, 33);
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(85, 30);
            this.txtValor.Size = new System.Drawing.Size(235, 27);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(15, 73);
            this.lblIndice.Text = "Índice:";
            // 
            // nudIndice
            // 
            this.nudIndice.Location = new System.Drawing.Point(85, 70);
            this.nudIndice.Size = new System.Drawing.Size(80, 27);
            this.nudIndice.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudIndice.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.nudIndice.Value = new decimal(new int[] {0, 0, 0, 0});
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(15, 115);
            this.btnAgregarInicio.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarInicio.Text = "Agregar al inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.Location = new System.Drawing.Point(175, 115);
            this.btnAgregarFinal.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarFinal.Text = "Agregar al final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(15, 152);
            this.btnInsertar.Size = new System.Drawing.Size(150, 30);
            this.btnInsertar.Text = "Insertar en índice";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminarEn
            // 
            this.btnEliminarEn.Location = new System.Drawing.Point(175, 152);
            this.btnEliminarEn.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarEn.Text = "Eliminar en índice";
            this.btnEliminarEn.UseVisualStyleBackColor = true;
            this.btnEliminarEn.Click += new System.EventHandler(this.btnEliminarEn_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.Location = new System.Drawing.Point(15, 189);
            this.btnEliminarPrimero.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarPrimero.Text = "Eliminar primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.Location = new System.Drawing.Point(175, 189);
            this.btnEliminarUltimo.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarUltimo.Text = "Eliminar último";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 226);
            this.btnBuscar.Size = new System.Drawing.Size(150, 30);
            this.btnBuscar.Text = "Buscar valor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(175, 226);
            this.btnObtener.Size = new System.Drawing.Size(150, 30);
            this.btnObtener.Text = "Obtener por índice";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(15, 263);
            this.btnInvertir.Size = new System.Drawing.Size(150, 30);
            this.btnInvertir.Text = "Invertir lista";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(175, 263);
            this.btnLimpiar.Size = new System.Drawing.Size(150, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = false;
            this.lblEstado.Location = new System.Drawing.Point(15, 310);
            this.lblEstado.Text = "";
            this.lblEstado.Size = new System.Drawing.Size(305, 50);
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 10F);
            // 
            // ListaEnlazadaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ListaEnlazadaControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lstNodos);
            this.Controls.Add(this.txtBitacora);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.grpOperaciones);
            this.grpOperaciones.Controls.Add(this.lblValor);
            this.grpOperaciones.Controls.Add(this.txtValor);
            this.grpOperaciones.Controls.Add(this.lblIndice);
            this.grpOperaciones.Controls.Add(this.nudIndice);
            this.grpOperaciones.Controls.Add(this.btnAgregarInicio);
            this.grpOperaciones.Controls.Add(this.btnAgregarFinal);
            this.grpOperaciones.Controls.Add(this.btnInsertar);
            this.grpOperaciones.Controls.Add(this.btnEliminarEn);
            this.grpOperaciones.Controls.Add(this.btnEliminarPrimero);
            this.grpOperaciones.Controls.Add(this.btnEliminarUltimo);
            this.grpOperaciones.Controls.Add(this.btnBuscar);
            this.grpOperaciones.Controls.Add(this.btnObtener);
            this.grpOperaciones.Controls.Add(this.btnInvertir);
            this.grpOperaciones.Controls.Add(this.btnLimpiar);
            this.grpOperaciones.Controls.Add(this.lblEstado);
            this.grpOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstNodos;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.NumericUpDown nudIndice;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminarEn;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEstado;
    }
}
