#nullable disable
namespace EstructurasLineales.Controles
{
    partial class ComparativaControl
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
            this.lvResultados = new System.Windows.Forms.ListView();
            this.colEstructura = new System.Windows.Forms.ColumnHeader();
            this.colInsercion = new System.Windows.Forms.ColumnHeader();
            this.colExtraccion = new System.Windows.Forms.ColumnHeader();
            this.colMemoria = new System.Windows.Forms.ColumnHeader();
            this.colBytes = new System.Windows.Forms.ColumnHeader();
            this.grpConclusion = new System.Windows.Forms.GroupBox();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblN = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.grpConclusion.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResultados
            // 
            this.lvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResultados.FullRowSelect = true;
            this.lvResultados.GridLines = true;
            this.lvResultados.View = System.Windows.Forms.View.Details;
            this.lvResultados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvResultados.HideSelection = false;
            this.lvResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.colEstructura, this.colInsercion, this.colExtraccion, this.colMemoria, this.colBytes});
            // 
            // colEstructura
            // 
            this.colEstructura.Text = "Estructura";
            this.colEstructura.Width = 290;
            // 
            // colInsercion
            // 
            this.colInsercion.Text = "Inserción (ms)";
            this.colInsercion.Width = 140;
            // 
            // colExtraccion
            // 
            this.colExtraccion.Text = "Extracción (ms)";
            this.colExtraccion.Width = 140;
            // 
            // colMemoria
            // 
            this.colMemoria.Text = "Memoria (KB)";
            this.colMemoria.Width = 140;
            // 
            // colBytes
            // 
            this.colBytes.Text = "Bytes por elemento";
            this.colBytes.Width = 160;
            // 
            // grpConclusion
            // 
            this.grpConclusion.Text = "Cómo leer los resultados";
            this.grpConclusion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpConclusion.Size = new System.Drawing.Size(100, 190);
            this.grpConclusion.Padding = new System.Windows.Forms.Padding(10);
            // 
            // lblConclusion
            // 
            this.lblConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConclusion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConclusion.Text = "";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Size = new System.Drawing.Size(100, 70);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(15, 24);
            this.lblN.Text = "Elementos (N):";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(130, 21);
            this.nudN.Size = new System.Drawing.Size(120, 27);
            this.nudN.Minimum = new decimal(new int[] {1000, 0, 0, 0});
            this.nudN.Maximum = new decimal(new int[] {2000000, 0, 0, 0});
            this.nudN.Value = new decimal(new int[] {100000, 0, 0, 0});
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(265, 18);
            this.btnComparar.Size = new System.Drawing.Size(200, 32);
            this.btnComparar.Text = "Ejecutar comparación";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = false;
            this.lblAviso.Location = new System.Drawing.Point(480, 14);
            this.lblAviso.Text = "Para tiempos fiables ejecuta en modo Release (Ctrl + F5). Los valores varían entre equipos y ejecuciones.";
            this.lblAviso.Size = new System.Drawing.Size(480, 44);
            this.lblAviso.ForeColor = System.Drawing.Color.DimGray;
            // 
            // ComparativaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ComparativaControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lvResultados);
            this.Controls.Add(this.grpConclusion);
            this.Controls.Add(this.pnlSuperior);
            this.grpConclusion.Controls.Add(this.lblConclusion);
            this.pnlSuperior.Controls.Add(this.lblN);
            this.pnlSuperior.Controls.Add(this.nudN);
            this.pnlSuperior.Controls.Add(this.btnComparar);
            this.pnlSuperior.Controls.Add(this.lblAviso);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.grpConclusion.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvResultados;
        private System.Windows.Forms.ColumnHeader colEstructura;
        private System.Windows.Forms.ColumnHeader colInsercion;
        private System.Windows.Forms.ColumnHeader colExtraccion;
        private System.Windows.Forms.ColumnHeader colMemoria;
        private System.Windows.Forms.ColumnHeader colBytes;
        private System.Windows.Forms.GroupBox grpConclusion;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblAviso;
    }
}
