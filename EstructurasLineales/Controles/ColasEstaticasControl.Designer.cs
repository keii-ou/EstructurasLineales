#nullable disable
namespace EstructurasLineales.Controles
{
    partial class ColasEstaticasControl
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
            this.tlpColas = new System.Windows.Forms.TableLayoutPanel();
            this.grpSimple = new System.Windows.Forms.GroupBox();
            this.lblSimpleElemento = new System.Windows.Forms.Label();
            this.txtSimple = new System.Windows.Forms.TextBox();
            this.btnSimpleEnqueue = new System.Windows.Forms.Button();
            this.btnSimpleDequeue = new System.Windows.Forms.Button();
            this.btnSimplePeek = new System.Windows.Forms.Button();
            this.btnSimpleIsEmpty = new System.Windows.Forms.Button();
            this.btnSimpleIsFull = new System.Windows.Forms.Button();
            this.lblSimpleInfo = new System.Windows.Forms.Label();
            this.lstSimple = new System.Windows.Forms.ListBox();
            this.grpCircular = new System.Windows.Forms.GroupBox();
            this.lblCircularElemento = new System.Windows.Forms.Label();
            this.txtCircular = new System.Windows.Forms.TextBox();
            this.btnCircularEnqueue = new System.Windows.Forms.Button();
            this.btnCircularDequeue = new System.Windows.Forms.Button();
            this.btnCircularPeek = new System.Windows.Forms.Button();
            this.btnCircularIsEmpty = new System.Windows.Forms.Button();
            this.btnCircularIsFull = new System.Windows.Forms.Button();
            this.lblCircularInfo = new System.Windows.Forms.Label();
            this.lstCircular = new System.Windows.Forms.ListBox();
            this.grpBitacora = new System.Windows.Forms.GroupBox();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.tlpColas.SuspendLayout();
            this.grpSimple.SuspendLayout();
            this.grpCircular.SuspendLayout();
            this.grpBitacora.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpColas
            // 
            this.tlpColas.ColumnCount = 2;
            this.tlpColas.RowCount = 1;
            this.tlpColas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpColas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // grpSimple
            // 
            this.grpSimple.Text = "Cola simple (lineal) – arreglo estático";
            this.grpSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSimple.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lblSimpleElemento
            // 
            this.lblSimpleElemento.AutoSize = true;
            this.lblSimpleElemento.Location = new System.Drawing.Point(15, 33);
            this.lblSimpleElemento.Text = "Elemento:";
            // 
            // txtSimple
            // 
            this.txtSimple.Location = new System.Drawing.Point(95, 30);
            this.txtSimple.Size = new System.Drawing.Size(150, 27);
            // 
            // btnSimpleEnqueue
            // 
            this.btnSimpleEnqueue.Location = new System.Drawing.Point(15, 68);
            this.btnSimpleEnqueue.Size = new System.Drawing.Size(105, 30);
            this.btnSimpleEnqueue.Text = "Enqueue";
            this.btnSimpleEnqueue.UseVisualStyleBackColor = true;
            this.btnSimpleEnqueue.Click += new System.EventHandler(this.btnSimpleEnqueue_Click);
            // 
            // btnSimpleDequeue
            // 
            this.btnSimpleDequeue.Location = new System.Drawing.Point(130, 68);
            this.btnSimpleDequeue.Size = new System.Drawing.Size(105, 30);
            this.btnSimpleDequeue.Text = "Dequeue";
            this.btnSimpleDequeue.UseVisualStyleBackColor = true;
            this.btnSimpleDequeue.Click += new System.EventHandler(this.btnSimpleDequeue_Click);
            // 
            // btnSimplePeek
            // 
            this.btnSimplePeek.Location = new System.Drawing.Point(245, 68);
            this.btnSimplePeek.Size = new System.Drawing.Size(105, 30);
            this.btnSimplePeek.Text = "Peek";
            this.btnSimplePeek.UseVisualStyleBackColor = true;
            this.btnSimplePeek.Click += new System.EventHandler(this.btnSimplePeek_Click);
            // 
            // btnSimpleIsEmpty
            // 
            this.btnSimpleIsEmpty.Location = new System.Drawing.Point(15, 104);
            this.btnSimpleIsEmpty.Size = new System.Drawing.Size(105, 30);
            this.btnSimpleIsEmpty.Text = "isEmpty";
            this.btnSimpleIsEmpty.UseVisualStyleBackColor = true;
            this.btnSimpleIsEmpty.Click += new System.EventHandler(this.btnSimpleIsEmpty_Click);
            // 
            // btnSimpleIsFull
            // 
            this.btnSimpleIsFull.Location = new System.Drawing.Point(130, 104);
            this.btnSimpleIsFull.Size = new System.Drawing.Size(105, 30);
            this.btnSimpleIsFull.Text = "isFull";
            this.btnSimpleIsFull.UseVisualStyleBackColor = true;
            this.btnSimpleIsFull.Click += new System.EventHandler(this.btnSimpleIsFull_Click);
            // 
            // lblSimpleInfo
            // 
            this.lblSimpleInfo.AutoSize = false;
            this.lblSimpleInfo.Location = new System.Drawing.Point(15, 145);
            this.lblSimpleInfo.Text = "";
            this.lblSimpleInfo.Size = new System.Drawing.Size(450, 48);
            this.lblSimpleInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblSimpleInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lstSimple
            // 
            this.lstSimple.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstSimple.FormattingEnabled = true;
            this.lstSimple.IntegralHeight = false;
            this.lstSimple.Location = new System.Drawing.Point(15, 200);
            this.lstSimple.Size = new System.Drawing.Size(450, 150);
            this.lstSimple.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // grpCircular
            // 
            this.grpCircular.Text = "Cola circular – arreglo estático";
            this.grpCircular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCircular.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lblCircularElemento
            // 
            this.lblCircularElemento.AutoSize = true;
            this.lblCircularElemento.Location = new System.Drawing.Point(15, 33);
            this.lblCircularElemento.Text = "Elemento:";
            // 
            // txtCircular
            // 
            this.txtCircular.Location = new System.Drawing.Point(95, 30);
            this.txtCircular.Size = new System.Drawing.Size(150, 27);
            // 
            // btnCircularEnqueue
            // 
            this.btnCircularEnqueue.Location = new System.Drawing.Point(15, 68);
            this.btnCircularEnqueue.Size = new System.Drawing.Size(105, 30);
            this.btnCircularEnqueue.Text = "Enqueue";
            this.btnCircularEnqueue.UseVisualStyleBackColor = true;
            this.btnCircularEnqueue.Click += new System.EventHandler(this.btnCircularEnqueue_Click);
            // 
            // btnCircularDequeue
            // 
            this.btnCircularDequeue.Location = new System.Drawing.Point(130, 68);
            this.btnCircularDequeue.Size = new System.Drawing.Size(105, 30);
            this.btnCircularDequeue.Text = "Dequeue";
            this.btnCircularDequeue.UseVisualStyleBackColor = true;
            this.btnCircularDequeue.Click += new System.EventHandler(this.btnCircularDequeue_Click);
            // 
            // btnCircularPeek
            // 
            this.btnCircularPeek.Location = new System.Drawing.Point(245, 68);
            this.btnCircularPeek.Size = new System.Drawing.Size(105, 30);
            this.btnCircularPeek.Text = "Peek";
            this.btnCircularPeek.UseVisualStyleBackColor = true;
            this.btnCircularPeek.Click += new System.EventHandler(this.btnCircularPeek_Click);
            // 
            // btnCircularIsEmpty
            // 
            this.btnCircularIsEmpty.Location = new System.Drawing.Point(15, 104);
            this.btnCircularIsEmpty.Size = new System.Drawing.Size(105, 30);
            this.btnCircularIsEmpty.Text = "isEmpty";
            this.btnCircularIsEmpty.UseVisualStyleBackColor = true;
            this.btnCircularIsEmpty.Click += new System.EventHandler(this.btnCircularIsEmpty_Click);
            // 
            // btnCircularIsFull
            // 
            this.btnCircularIsFull.Location = new System.Drawing.Point(130, 104);
            this.btnCircularIsFull.Size = new System.Drawing.Size(105, 30);
            this.btnCircularIsFull.Text = "isFull";
            this.btnCircularIsFull.UseVisualStyleBackColor = true;
            this.btnCircularIsFull.Click += new System.EventHandler(this.btnCircularIsFull_Click);
            // 
            // lblCircularInfo
            // 
            this.lblCircularInfo.AutoSize = false;
            this.lblCircularInfo.Location = new System.Drawing.Point(15, 145);
            this.lblCircularInfo.Text = "";
            this.lblCircularInfo.Size = new System.Drawing.Size(450, 48);
            this.lblCircularInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblCircularInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lstCircular
            // 
            this.lstCircular.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstCircular.FormattingEnabled = true;
            this.lstCircular.IntegralHeight = false;
            this.lstCircular.Location = new System.Drawing.Point(15, 200);
            this.lstCircular.Size = new System.Drawing.Size(450, 150);
            this.lstCircular.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // grpBitacora
            // 
            this.grpBitacora.Text = "Bitácora";
            this.grpBitacora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBitacora.Size = new System.Drawing.Size(100, 140);
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
            // pnlSuperior
            // 
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Size = new System.Drawing.Size(100, 70);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(15, 22);
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(95, 19);
            this.nudCapacidad.Size = new System.Drawing.Size(70, 27);
            this.nudCapacidad.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCapacidad.Maximum = new decimal(new int[] {20, 0, 0, 0});
            this.nudCapacidad.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(175, 17);
            this.btnCrear.Size = new System.Drawing.Size(130, 30);
            this.btnCrear.Text = "Crear colas";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = false;
            this.lblNota.Location = new System.Drawing.Point(330, 10);
            this.lblNota.Text = "Prueba sugerida: llena la cola, haz 2 Dequeue y vuelve a hacer Enqueue. La cola simple dirá «llena» aunque haya casillas libres al inicio; la circular reutiliza ese espacio con (rear + 1) % capacidad.";
            this.lblNota.Size = new System.Drawing.Size(640, 52);
            this.lblNota.ForeColor = System.Drawing.Color.DimGray;
            // 
            // ColasEstaticasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ColasEstaticasControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tlpColas);
            this.Controls.Add(this.grpBitacora);
            this.Controls.Add(this.pnlSuperior);
            this.tlpColas.Controls.Add(this.grpSimple, 0, 0);
            this.tlpColas.Controls.Add(this.grpCircular, 1, 0);
            this.grpSimple.Controls.Add(this.lblSimpleElemento);
            this.grpSimple.Controls.Add(this.txtSimple);
            this.grpSimple.Controls.Add(this.btnSimpleEnqueue);
            this.grpSimple.Controls.Add(this.btnSimpleDequeue);
            this.grpSimple.Controls.Add(this.btnSimplePeek);
            this.grpSimple.Controls.Add(this.btnSimpleIsEmpty);
            this.grpSimple.Controls.Add(this.btnSimpleIsFull);
            this.grpSimple.Controls.Add(this.lblSimpleInfo);
            this.grpSimple.Controls.Add(this.lstSimple);
            this.grpCircular.Controls.Add(this.lblCircularElemento);
            this.grpCircular.Controls.Add(this.txtCircular);
            this.grpCircular.Controls.Add(this.btnCircularEnqueue);
            this.grpCircular.Controls.Add(this.btnCircularDequeue);
            this.grpCircular.Controls.Add(this.btnCircularPeek);
            this.grpCircular.Controls.Add(this.btnCircularIsEmpty);
            this.grpCircular.Controls.Add(this.btnCircularIsFull);
            this.grpCircular.Controls.Add(this.lblCircularInfo);
            this.grpCircular.Controls.Add(this.lstCircular);
            this.grpBitacora.Controls.Add(this.txtBitacora);
            this.pnlSuperior.Controls.Add(this.lblCapacidad);
            this.pnlSuperior.Controls.Add(this.nudCapacidad);
            this.pnlSuperior.Controls.Add(this.btnCrear);
            this.pnlSuperior.Controls.Add(this.lblNota);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.grpBitacora.ResumeLayout(false);
            this.grpCircular.ResumeLayout(false);
            this.grpSimple.ResumeLayout(false);
            this.tlpColas.ResumeLayout(false);
            this.tlpColas.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpColas;
        private System.Windows.Forms.GroupBox grpSimple;
        private System.Windows.Forms.Label lblSimpleElemento;
        private System.Windows.Forms.TextBox txtSimple;
        private System.Windows.Forms.Button btnSimpleEnqueue;
        private System.Windows.Forms.Button btnSimpleDequeue;
        private System.Windows.Forms.Button btnSimplePeek;
        private System.Windows.Forms.Button btnSimpleIsEmpty;
        private System.Windows.Forms.Button btnSimpleIsFull;
        private System.Windows.Forms.Label lblSimpleInfo;
        private System.Windows.Forms.ListBox lstSimple;
        private System.Windows.Forms.GroupBox grpCircular;
        private System.Windows.Forms.Label lblCircularElemento;
        private System.Windows.Forms.TextBox txtCircular;
        private System.Windows.Forms.Button btnCircularEnqueue;
        private System.Windows.Forms.Button btnCircularDequeue;
        private System.Windows.Forms.Button btnCircularPeek;
        private System.Windows.Forms.Button btnCircularIsEmpty;
        private System.Windows.Forms.Button btnCircularIsFull;
        private System.Windows.Forms.Label lblCircularInfo;
        private System.Windows.Forms.ListBox lstCircular;
        private System.Windows.Forms.GroupBox grpBitacora;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblNota;
    }
}
