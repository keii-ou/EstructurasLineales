#nullable disable
namespace EstructurasLineales
{
    partial class MainForm
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
            tabControlPrincipal = new TabControl();
            tpPilaEstatica = new TabPage();
            pilaEstaticaControl = new EstructurasLineales.Controles.PilaEstaticaControl();
            tpColasEstaticas = new TabPage();
            colasEstaticasControl = new EstructurasLineales.Controles.ColasEstaticasControl();
            tpLista = new TabPage();
            listaEnlazadaControl = new EstructurasLineales.Controles.ListaEnlazadaControl();
            tpPilaColaDin = new TabPage();
            pilaColaDinamicaControl = new EstructurasLineales.Controles.PilaColaDinamicaControl();
            tpComparativa = new TabPage();
            comparativaControl = new EstructurasLineales.Controles.ComparativaControl();
            tpAeropuerto = new TabPage();
            aeropuertoControl = new EstructurasLineales.Controles.AeropuertoControl();
            tabControlPrincipal.SuspendLayout();
            tpPilaEstatica.SuspendLayout();
            tpColasEstaticas.SuspendLayout();
            tpLista.SuspendLayout();
            tpPilaColaDin.SuspendLayout();
            tpComparativa.SuspendLayout();
            tpAeropuerto.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tpPilaEstatica);
            tabControlPrincipal.Controls.Add(tpColasEstaticas);
            tabControlPrincipal.Controls.Add(tpLista);
            tabControlPrincipal.Controls.Add(tpPilaColaDin);
            tabControlPrincipal.Controls.Add(tpComparativa);
            tabControlPrincipal.Controls.Add(tpAeropuerto);
            tabControlPrincipal.Dock = DockStyle.Fill;
            tabControlPrincipal.Font = new Font("Segoe UI", 10F);
            tabControlPrincipal.Location = new Point(0, 0);
            tabControlPrincipal.Margin = new Padding(3, 2, 3, 2);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.Padding = new Point(16, 6);
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(962, 525);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tpPilaEstatica
            // 
            tpPilaEstatica.Controls.Add(pilaEstaticaControl);
            tpPilaEstatica.Location = new Point(4, 32);
            tpPilaEstatica.Margin = new Padding(3, 2, 3, 2);
            tpPilaEstatica.Name = "tpPilaEstatica";
            tpPilaEstatica.Padding = new Padding(3, 2, 3, 2);
            tpPilaEstatica.Size = new Size(954, 489);
            tpPilaEstatica.TabIndex = 0;
            tpPilaEstatica.Text = "Pila estática";
            tpPilaEstatica.UseVisualStyleBackColor = true;
            // 
            // pilaEstaticaControl
            // 
            pilaEstaticaControl.Dock = DockStyle.Fill;
            pilaEstaticaControl.Location = new Point(3, 2);
            pilaEstaticaControl.Margin = new Padding(3, 2, 3, 2);
            pilaEstaticaControl.Name = "pilaEstaticaControl";
            pilaEstaticaControl.Size = new Size(948, 485);
            pilaEstaticaControl.TabIndex = 0;
            pilaEstaticaControl.Load += pilaEstaticaControl_Load;
            // 
            // tpColasEstaticas
            // 
            tpColasEstaticas.Controls.Add(colasEstaticasControl);
            tpColasEstaticas.Location = new Point(4, 32);
            tpColasEstaticas.Margin = new Padding(3, 2, 3, 2);
            tpColasEstaticas.Name = "tpColasEstaticas";
            tpColasEstaticas.Padding = new Padding(3, 2, 3, 2);
            tpColasEstaticas.Size = new Size(954, 489);
            tpColasEstaticas.TabIndex = 1;
            tpColasEstaticas.Text = "Colas estáticas";
            tpColasEstaticas.UseVisualStyleBackColor = true;
            // 
            // colasEstaticasControl
            // 
            colasEstaticasControl.Dock = DockStyle.Fill;
            colasEstaticasControl.Location = new Point(3, 2);
            colasEstaticasControl.Margin = new Padding(3, 2, 3, 2);
            colasEstaticasControl.Name = "colasEstaticasControl";
            colasEstaticasControl.Size = new Size(948, 485);
            colasEstaticasControl.TabIndex = 0;
            // 
            // tpLista
            // 
            tpLista.Controls.Add(listaEnlazadaControl);
            tpLista.Location = new Point(4, 32);
            tpLista.Margin = new Padding(3, 2, 3, 2);
            tpLista.Name = "tpLista";
            tpLista.Padding = new Padding(3, 2, 3, 2);
            tpLista.Size = new Size(192, 64);
            tpLista.TabIndex = 2;
            tpLista.Text = "Lista enlazada";
            tpLista.UseVisualStyleBackColor = true;
            // 
            // listaEnlazadaControl
            // 
            listaEnlazadaControl.Dock = DockStyle.Fill;
            listaEnlazadaControl.Location = new Point(3, 2);
            listaEnlazadaControl.Margin = new Padding(3, 2, 3, 2);
            listaEnlazadaControl.Name = "listaEnlazadaControl";
            listaEnlazadaControl.Size = new Size(186, 60);
            listaEnlazadaControl.TabIndex = 0;
            // 
            // tpPilaColaDin
            // 
            tpPilaColaDin.Controls.Add(pilaColaDinamicaControl);
            tpPilaColaDin.Location = new Point(4, 32);
            tpPilaColaDin.Margin = new Padding(3, 2, 3, 2);
            tpPilaColaDin.Name = "tpPilaColaDin";
            tpPilaColaDin.Padding = new Padding(3, 2, 3, 2);
            tpPilaColaDin.Size = new Size(192, 64);
            tpPilaColaDin.TabIndex = 3;
            tpPilaColaDin.Text = "Pila y cola dinámicas";
            tpPilaColaDin.UseVisualStyleBackColor = true;
            // 
            // pilaColaDinamicaControl
            // 
            pilaColaDinamicaControl.Dock = DockStyle.Fill;
            pilaColaDinamicaControl.Location = new Point(3, 2);
            pilaColaDinamicaControl.Margin = new Padding(3, 2, 3, 2);
            pilaColaDinamicaControl.Name = "pilaColaDinamicaControl";
            pilaColaDinamicaControl.Size = new Size(186, 60);
            pilaColaDinamicaControl.TabIndex = 0;
            // 
            // tpComparativa
            // 
            tpComparativa.Controls.Add(comparativaControl);
            tpComparativa.Location = new Point(4, 32);
            tpComparativa.Margin = new Padding(3, 2, 3, 2);
            tpComparativa.Name = "tpComparativa";
            tpComparativa.Padding = new Padding(3, 2, 3, 2);
            tpComparativa.Size = new Size(192, 64);
            tpComparativa.TabIndex = 4;
            tpComparativa.Text = "Estático vs dinámico";
            tpComparativa.UseVisualStyleBackColor = true;
            // 
            // comparativaControl
            // 
            comparativaControl.Dock = DockStyle.Fill;
            comparativaControl.Location = new Point(3, 2);
            comparativaControl.Margin = new Padding(3, 2, 3, 2);
            comparativaControl.Name = "comparativaControl";
            comparativaControl.Size = new Size(186, 60);
            comparativaControl.TabIndex = 0;
            // 
            // tpAeropuerto
            // 
            tpAeropuerto.Controls.Add(aeropuertoControl);
            tpAeropuerto.Location = new Point(4, 32);
            tpAeropuerto.Margin = new Padding(3, 2, 3, 2);
            tpAeropuerto.Name = "tpAeropuerto";
            tpAeropuerto.Padding = new Padding(3, 2, 3, 2);
            tpAeropuerto.Size = new Size(192, 64);
            tpAeropuerto.TabIndex = 5;
            tpAeropuerto.Text = "Despacho de aviones";
            tpAeropuerto.UseVisualStyleBackColor = true;
            // 
            // aeropuertoControl
            // 
            aeropuertoControl.Dock = DockStyle.Fill;
            aeropuertoControl.Location = new Point(3, 2);
            aeropuertoControl.Margin = new Padding(3, 2, 3, 2);
            aeropuertoControl.Name = "aeropuertoControl";
            aeropuertoControl.Size = new Size(186, 60);
            aeropuertoControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 525);
            Controls.Add(tabControlPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 497);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControlPrincipal.ResumeLayout(false);
            tpPilaEstatica.ResumeLayout(false);
            tpColasEstaticas.ResumeLayout(false);
            tpLista.ResumeLayout(false);
            tpPilaColaDin.ResumeLayout(false);
            tpComparativa.ResumeLayout(false);
            tpAeropuerto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tpPilaEstatica;
        private EstructurasLineales.Controles.PilaEstaticaControl pilaEstaticaControl;
        private System.Windows.Forms.TabPage tpColasEstaticas;
        private EstructurasLineales.Controles.ColasEstaticasControl colasEstaticasControl;
        private System.Windows.Forms.TabPage tpLista;
        private EstructurasLineales.Controles.ListaEnlazadaControl listaEnlazadaControl;
        private System.Windows.Forms.TabPage tpPilaColaDin;
        private EstructurasLineales.Controles.PilaColaDinamicaControl pilaColaDinamicaControl;
        private System.Windows.Forms.TabPage tpComparativa;
        private EstructurasLineales.Controles.ComparativaControl comparativaControl;
        private System.Windows.Forms.TabPage tpAeropuerto;
        private EstructurasLineales.Controles.AeropuertoControl aeropuertoControl;
    }
}
