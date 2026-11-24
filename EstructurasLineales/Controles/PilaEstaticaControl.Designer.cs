#nullable disable
namespace EstructurasLineales.Controles
{
    partial class PilaEstaticaControl
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
            this.grpVisual = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.grpBitacora = new System.Windows.Forms.GroupBox();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.grpCapacidad = new System.Windows.Forms.GroupBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnIsEmpty = new System.Windows.Forms.Button();
            this.btnIsFull = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpVisual.SuspendLayout();
            this.grpBitacora.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            this.grpCapacidad.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVisual
            // 
            this.grpVisual.Text = "Visualización del arreglo (tope arriba)";
            this.grpVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVisual.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lstPila
            // 
            this.lstPila.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstPila.FormattingEnabled = true;
            this.lstPila.IntegralHeight = false;
            this.lstPila.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // grpBitacora
            // 
            this.grpBitacora.Text = "Bitácora";
            this.grpBitacora.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBitacora.Size = new System.Drawing.Size(300, 100);
            this.grpBitacora.Padding = new System.Windows.Forms.Padding(8);
            // 
            // txtBitacora
            // 
            this.txtBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBitacora.Multiline = true;
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtBitacora.BackColor = System.Drawing.SystemColors.Window;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Size = new System.Drawing.Size(330, 100);
            // 
            // grpCapacidad
            // 
            this.grpCapacidad.Text = "1. Configuración";
            this.grpCapacidad.Location = new System.Drawing.Point(10, 10);
            this.grpCapacidad.Size = new System.Drawing.Size(310, 70);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(15, 31);
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(95, 28);
            this.nudCapacidad.Size = new System.Drawing.Size(70, 27);
            this.nudCapacidad.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCapacidad.Maximum = new decimal(new int[] {20, 0, 0, 0});
            this.nudCapacidad.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(175, 26);
            this.btnCrear.Size = new System.Drawing.Size(120, 30);
            this.btnCrear.Text = "Crear pila";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Text = "2. Operaciones";
            this.grpOperaciones.Location = new System.Drawing.Point(10, 90);
            this.grpOperaciones.Size = new System.Drawing.Size(310, 280);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(15, 33);
            this.lblElemento.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(95, 30);
            this.txtElemento.Size = new System.Drawing.Size(200, 27);
            this.txtElemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtElemento_KeyDown);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(15, 70);
            this.btnPush.Size = new System.Drawing.Size(135, 30);
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(160, 70);
            this.btnPop.Size = new System.Drawing.Size(135, 30);
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(15, 108);
            this.btnPeek.Size = new System.Drawing.Size(135, 30);
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnIsEmpty
            // 
            this.btnIsEmpty.Location = new System.Drawing.Point(160, 108);
            this.btnIsEmpty.Size = new System.Drawing.Size(135, 30);
            this.btnIsEmpty.Text = "isEmpty";
            this.btnIsEmpty.UseVisualStyleBackColor = true;
            this.btnIsEmpty.Click += new System.EventHandler(this.btnIsEmpty_Click);
            // 
            // btnIsFull
            // 
            this.btnIsFull.Location = new System.Drawing.Point(15, 146);
            this.btnIsFull.Size = new System.Drawing.Size(135, 30);
            this.btnIsFull.Text = "isFull";
            this.btnIsFull.UseVisualStyleBackColor = true;
            this.btnIsFull.Click += new System.EventHandler(this.btnIsFull_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = false;
            this.lblEstado.Location = new System.Drawing.Point(15, 195);
            this.lblEstado.Text = "";
            this.lblEstado.Size = new System.Drawing.Size(280, 70);
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 10F);
            // 
            // PilaEstaticaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PilaEstaticaControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.grpVisual);
            this.Controls.Add(this.grpBitacora);
            this.Controls.Add(this.pnlIzquierdo);
            this.grpVisual.Controls.Add(this.lstPila);
            this.grpBitacora.Controls.Add(this.txtBitacora);
            this.pnlIzquierdo.Controls.Add(this.grpCapacidad);
            this.pnlIzquierdo.Controls.Add(this.grpOperaciones);
            this.grpCapacidad.Controls.Add(this.lblCapacidad);
            this.grpCapacidad.Controls.Add(this.nudCapacidad);
            this.grpCapacidad.Controls.Add(this.btnCrear);
            this.grpOperaciones.Controls.Add(this.lblElemento);
            this.grpOperaciones.Controls.Add(this.txtElemento);
            this.grpOperaciones.Controls.Add(this.btnPush);
            this.grpOperaciones.Controls.Add(this.btnPop);
            this.grpOperaciones.Controls.Add(this.btnPeek);
            this.grpOperaciones.Controls.Add(this.btnIsEmpty);
            this.grpOperaciones.Controls.Add(this.btnIsFull);
            this.grpOperaciones.Controls.Add(this.lblEstado);
            this.grpOperaciones.ResumeLayout(false);
            this.grpCapacidad.ResumeLayout(false);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            this.grpBitacora.ResumeLayout(false);
            this.grpVisual.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpVisual;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox grpBitacora;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.GroupBox grpCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnIsEmpty;
        private System.Windows.Forms.Button btnIsFull;
        private System.Windows.Forms.Label lblEstado;
    }
}
