#nullable disable
namespace EstructurasLineales.Controles
{
    partial class PilaColaDinamicaControl
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
            this.tlpDin = new System.Windows.Forms.TableLayoutPanel();
            this.grpPila = new System.Windows.Forms.GroupBox();
            this.lblPilaElemento = new System.Windows.Forms.Label();
            this.txtPila = new System.Windows.Forms.TextBox();
            this.btnPilaPush = new System.Windows.Forms.Button();
            this.btnPilaPop = new System.Windows.Forms.Button();
            this.btnPilaPeek = new System.Windows.Forms.Button();
            this.btnPilaIsEmpty = new System.Windows.Forms.Button();
            this.btnPilaMasivo = new System.Windows.Forms.Button();
            this.lblPilaInfo = new System.Windows.Forms.Label();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.grpCola = new System.Windows.Forms.GroupBox();
            this.lblColaElemento = new System.Windows.Forms.Label();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnColaEnqueue = new System.Windows.Forms.Button();
            this.btnColaDequeue = new System.Windows.Forms.Button();
            this.btnColaPeek = new System.Windows.Forms.Button();
            this.btnColaIsEmpty = new System.Windows.Forms.Button();
            this.btnColaMasivo = new System.Windows.Forms.Button();
            this.lblColaInfo = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.grpBitacora = new System.Windows.Forms.GroupBox();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();
            this.tlpDin.SuspendLayout();
            this.grpPila.SuspendLayout();
            this.grpCola.SuspendLayout();
            this.grpBitacora.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDin
            // 
            this.tlpDin.ColumnCount = 2;
            this.tlpDin.RowCount = 1;
            this.tlpDin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // grpPila
            // 
            this.grpPila.Text = "Pila dinámica (nodos enlazados)";
            this.grpPila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPila.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lblPilaElemento
            // 
            this.lblPilaElemento.AutoSize = true;
            this.lblPilaElemento.Location = new System.Drawing.Point(15, 33);
            this.lblPilaElemento.Text = "Elemento:";
            // 
            // txtPila
            // 
            this.txtPila.Location = new System.Drawing.Point(95, 30);
            this.txtPila.Size = new System.Drawing.Size(150, 27);
            // 
            // btnPilaPush
            // 
            this.btnPilaPush.Location = new System.Drawing.Point(15, 68);
            this.btnPilaPush.Size = new System.Drawing.Size(105, 30);
            this.btnPilaPush.Text = "Push";
            this.btnPilaPush.UseVisualStyleBackColor = true;
            this.btnPilaPush.Click += new System.EventHandler(this.btnPilaPush_Click);
            // 
            // btnPilaPop
            // 
            this.btnPilaPop.Location = new System.Drawing.Point(130, 68);
            this.btnPilaPop.Size = new System.Drawing.Size(105, 30);
            this.btnPilaPop.Text = "Pop";
            this.btnPilaPop.UseVisualStyleBackColor = true;
            this.btnPilaPop.Click += new System.EventHandler(this.btnPilaPop_Click);
            // 
            // btnPilaPeek
            // 
            this.btnPilaPeek.Location = new System.Drawing.Point(245, 68);
            this.btnPilaPeek.Size = new System.Drawing.Size(105, 30);
            this.btnPilaPeek.Text = "Peek";
            this.btnPilaPeek.UseVisualStyleBackColor = true;
            this.btnPilaPeek.Click += new System.EventHandler(this.btnPilaPeek_Click);
            // 
            // btnPilaIsEmpty
            // 
            this.btnPilaIsEmpty.Location = new System.Drawing.Point(15, 104);
            this.btnPilaIsEmpty.Size = new System.Drawing.Size(105, 30);
            this.btnPilaIsEmpty.Text = "isEmpty";
            this.btnPilaIsEmpty.UseVisualStyleBackColor = true;
            this.btnPilaIsEmpty.Click += new System.EventHandler(this.btnPilaIsEmpty_Click);
            // 
            // btnPilaMasivo
            // 
            this.btnPilaMasivo.Location = new System.Drawing.Point(130, 104);
            this.btnPilaMasivo.Size = new System.Drawing.Size(220, 30);
            this.btnPilaMasivo.Text = "Push ×20 (sin límite)";
            this.btnPilaMasivo.UseVisualStyleBackColor = true;
            this.btnPilaMasivo.Click += new System.EventHandler(this.btnPilaMasivo_Click);
            // 
            // lblPilaInfo
            // 
            this.lblPilaInfo.AutoSize = false;
            this.lblPilaInfo.Location = new System.Drawing.Point(15, 145);
            this.lblPilaInfo.Text = "";
            this.lblPilaInfo.Size = new System.Drawing.Size(450, 48);
            this.lblPilaInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblPilaInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lstPila
            // 
            this.lstPila.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstPila.FormattingEnabled = true;
            this.lstPila.IntegralHeight = false;
            this.lstPila.Location = new System.Drawing.Point(15, 200);
            this.lstPila.Size = new System.Drawing.Size(450, 150);
            this.lstPila.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // grpCola
            // 
            this.grpCola.Text = "Cola dinámica (frente y final)";
            this.grpCola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCola.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lblColaElemento
            // 
            this.lblColaElemento.AutoSize = true;
            this.lblColaElemento.Location = new System.Drawing.Point(15, 33);
            this.lblColaElemento.Text = "Elemento:";
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(95, 30);
            this.txtCola.Size = new System.Drawing.Size(150, 27);
            // 
            // btnColaEnqueue
            // 
            this.btnColaEnqueue.Location = new System.Drawing.Point(15, 68);
            this.btnColaEnqueue.Size = new System.Drawing.Size(105, 30);
            this.btnColaEnqueue.Text = "Enqueue";
            this.btnColaEnqueue.UseVisualStyleBackColor = true;
            this.btnColaEnqueue.Click += new System.EventHandler(this.btnColaEnqueue_Click);
            // 
            // btnColaDequeue
            // 
            this.btnColaDequeue.Location = new System.Drawing.Point(130, 68);
            this.btnColaDequeue.Size = new System.Drawing.Size(105, 30);
            this.btnColaDequeue.Text = "Dequeue";
            this.btnColaDequeue.UseVisualStyleBackColor = true;
            this.btnColaDequeue.Click += new System.EventHandler(this.btnColaDequeue_Click);
            // 
            // btnColaPeek
            // 
            this.btnColaPeek.Location = new System.Drawing.Point(245, 68);
            this.btnColaPeek.Size = new System.Drawing.Size(105, 30);
            this.btnColaPeek.Text = "Peek";
            this.btnColaPeek.UseVisualStyleBackColor = true;
            this.btnColaPeek.Click += new System.EventHandler(this.btnColaPeek_Click);
            // 
            // btnColaIsEmpty
            // 
            this.btnColaIsEmpty.Location = new System.Drawing.Point(15, 104);
            this.btnColaIsEmpty.Size = new System.Drawing.Size(105, 30);
            this.btnColaIsEmpty.Text = "isEmpty";
            this.btnColaIsEmpty.UseVisualStyleBackColor = true;
            this.btnColaIsEmpty.Click += new System.EventHandler(this.btnColaIsEmpty_Click);
            // 
            // btnColaMasivo
            // 
            this.btnColaMasivo.Location = new System.Drawing.Point(130, 104);
            this.btnColaMasivo.Size = new System.Drawing.Size(220, 30);
            this.btnColaMasivo.Text = "Enqueue ×20 (sin límite)";
            this.btnColaMasivo.UseVisualStyleBackColor = true;
            this.btnColaMasivo.Click += new System.EventHandler(this.btnColaMasivo_Click);
            // 
            // lblColaInfo
            // 
            this.lblColaInfo.AutoSize = false;
            this.lblColaInfo.Location = new System.Drawing.Point(15, 145);
            this.lblColaInfo.Text = "";
            this.lblColaInfo.Size = new System.Drawing.Size(450, 48);
            this.lblColaInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblColaInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lstCola
            // 
            this.lstCola.Font = new System.Drawing.Font("Consolas", 13F);
            this.lstCola.FormattingEnabled = true;
            this.lstCola.IntegralHeight = false;
            this.lstCola.Location = new System.Drawing.Point(15, 200);
            this.lstCola.Size = new System.Drawing.Size(450, 150);
            this.lstCola.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            this.pnlSuperior.Size = new System.Drawing.Size(100, 60);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = false;
            this.lblNota.Location = new System.Drawing.Point(15, 10);
            this.lblNota.Text = "Aquí no existe isFull: cada elemento vive en un nodo creado con new, por lo que la estructura solo está limitada por la memoria disponible. Cada nodo guarda el dato y una referencia al siguiente.";
            this.lblNota.Size = new System.Drawing.Size(960, 44);
            this.lblNota.ForeColor = System.Drawing.Color.DimGray;
            // 
            // PilaColaDinamicaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PilaColaDinamicaControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tlpDin);
            this.Controls.Add(this.grpBitacora);
            this.Controls.Add(this.pnlSuperior);
            this.tlpDin.Controls.Add(this.grpPila, 0, 0);
            this.tlpDin.Controls.Add(this.grpCola, 1, 0);
            this.grpPila.Controls.Add(this.lblPilaElemento);
            this.grpPila.Controls.Add(this.txtPila);
            this.grpPila.Controls.Add(this.btnPilaPush);
            this.grpPila.Controls.Add(this.btnPilaPop);
            this.grpPila.Controls.Add(this.btnPilaPeek);
            this.grpPila.Controls.Add(this.btnPilaIsEmpty);
            this.grpPila.Controls.Add(this.btnPilaMasivo);
            this.grpPila.Controls.Add(this.lblPilaInfo);
            this.grpPila.Controls.Add(this.lstPila);
            this.grpCola.Controls.Add(this.lblColaElemento);
            this.grpCola.Controls.Add(this.txtCola);
            this.grpCola.Controls.Add(this.btnColaEnqueue);
            this.grpCola.Controls.Add(this.btnColaDequeue);
            this.grpCola.Controls.Add(this.btnColaPeek);
            this.grpCola.Controls.Add(this.btnColaIsEmpty);
            this.grpCola.Controls.Add(this.btnColaMasivo);
            this.grpCola.Controls.Add(this.lblColaInfo);
            this.grpCola.Controls.Add(this.lstCola);
            this.grpBitacora.Controls.Add(this.txtBitacora);
            this.pnlSuperior.Controls.Add(this.lblNota);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.grpBitacora.ResumeLayout(false);
            this.grpCola.ResumeLayout(false);
            this.grpPila.ResumeLayout(false);
            this.tlpDin.ResumeLayout(false);
            this.tlpDin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDin;
        private System.Windows.Forms.GroupBox grpPila;
        private System.Windows.Forms.Label lblPilaElemento;
        private System.Windows.Forms.TextBox txtPila;
        private System.Windows.Forms.Button btnPilaPush;
        private System.Windows.Forms.Button btnPilaPop;
        private System.Windows.Forms.Button btnPilaPeek;
        private System.Windows.Forms.Button btnPilaIsEmpty;
        private System.Windows.Forms.Button btnPilaMasivo;
        private System.Windows.Forms.Label lblPilaInfo;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox grpCola;
        private System.Windows.Forms.Label lblColaElemento;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnColaEnqueue;
        private System.Windows.Forms.Button btnColaDequeue;
        private System.Windows.Forms.Button btnColaPeek;
        private System.Windows.Forms.Button btnColaIsEmpty;
        private System.Windows.Forms.Button btnColaMasivo;
        private System.Windows.Forms.Label lblColaInfo;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox grpBitacora;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblNota;
    }
}
