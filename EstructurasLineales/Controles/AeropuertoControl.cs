using EstructurasLineales.Estructuras.Dinamicas;
using EstructurasLineales.Modelos;

namespace EstructurasLineales.Controles;


// Caso: despacho de aviones con una COLA DE PRIORIDAD dinámica.
// Las emergencias pasan por delante de todos; dentro del mismo nivel se respeta el orden de llegada.
// El historial de despachos se guarda en una PILA dinámica (el último despachado se ve primero).

public partial class AeropuertoControl : UserControl
{
    private readonly ColaPrioridad<Vuelo> _espera = new();
    private readonly PilaDinamica<Vuelo> _historial = new();
    private readonly Random _azar = new();
    private readonly string[] _aerolineas = { "AM", "VB", "Y4", "AA", "UA", "DL", "CM" };
    private int _consecutivo = 100;

    public AeropuertoControl()
    {
        InitializeComponent();
        cboTipo.DataSource = Enum.GetValues<TipoVuelo>();
        cboTipo.SelectedItem = TipoVuelo.Comercial;
        Actualizar();
    }

    private void Actualizar()
    {
        lvEspera.BeginUpdate();
        lvEspera.Items.Clear();
        int turno = 1;
        foreach (var (vuelo, prioridad) in _espera.Elementos())
        {
            var fila = new ListViewItem(turno.ToString());
            fila.SubItems.Add(vuelo.Codigo);
            fila.SubItems.Add(vuelo.Tipo.ToString());
            fila.SubItems.Add(prioridad.ToString());
            fila.SubItems.Add(vuelo.Solicitud.ToString("HH:mm:ss"));
            if (vuelo.Tipo == TipoVuelo.Emergencia)
            {
                fila.BackColor = Color.MistyRose;
                fila.ForeColor = Color.Firebrick;
            }
            lvEspera.Items.Add(fila);
            turno++;
        }
        lvEspera.EndUpdate();
        grpEspera.Text = $"Cola de espera (prioridad) – {_espera.Count} vuelo(s)";

        lstHistorial.BeginUpdate();
        lstHistorial.Items.Clear();
        foreach (Vuelo v in _historial)
            lstHistorial.Items.Add($"{v.Codigo}  {v.Tipo}");
        lstHistorial.EndUpdate();
    }

    private void Solicitar(string codigo, TipoVuelo tipo)
    {
        var vuelo = new Vuelo(codigo, tipo, DateTime.Now);
        _espera.Enqueue(vuelo, vuelo.Prioridad);
    }

    private string NuevoCodigo() => $"{_aerolineas[_azar.Next(_aerolineas.Length)]}{_consecutivo++}";

    private void btnSolicitar_Click(object? sender, EventArgs e)
    {
        string codigo = txtCodigo.Text.Trim().ToUpperInvariant();
        if (codigo.Length == 0) codigo = NuevoCodigo();

        var tipo = cboTipo.SelectedItem is TipoVuelo seleccionado ? seleccionado : TipoVuelo.Comercial;
        Solicitar(codigo, tipo);
        txtCodigo.Clear();
        Actualizar();
    }

    private void btnAleatorios_Click(object? sender, EventArgs e)
    {
        for (int i = 0; i < 5; i++)
        {
            int dado = _azar.Next(100);
            TipoVuelo tipo = dado < 10 ? TipoVuelo.Emergencia
                           : dado < 60 ? TipoVuelo.Comercial
                           : dado < 85 ? TipoVuelo.Carga
                           : TipoVuelo.Privado;
            Solicitar(NuevoCodigo(), tipo);
        }
        Actualizar();
    }

    private void btnDespachar_Click(object? sender, EventArgs e)
    {
        if (_espera.IsEmpty())
        {
            MessageBox.Show("No hay vuelos en espera.", "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Vuelo vuelo = _espera.Dequeue();
        _historial.Push(vuelo);
        lblPista.Text = $"Pista asignada a{Environment.NewLine}{vuelo.Codigo} ({vuelo.Tipo})";
        lblPista.ForeColor = vuelo.Tipo == TipoVuelo.Emergencia ? Color.Firebrick : Color.DarkGreen;
        Actualizar();
    }

    private void btnSiguiente_Click(object? sender, EventArgs e)
    {
        if (_espera.IsEmpty())
        {
            MessageBox.Show("No hay vuelos en espera.", "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Vuelo vuelo = _espera.Peek();
        MessageBox.Show($"Siguiente en despachar: {vuelo.Codigo} ({vuelo.Tipo}, prioridad {vuelo.Prioridad}).",
            "Peek", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnReiniciar_Click(object? sender, EventArgs e)
    {
        _espera.Limpiar();
        _historial.Limpiar();
        lblPista.Text = "Pista libre";
        lblPista.ForeColor = SystemColors.ControlText;
        Actualizar();
    }
}
