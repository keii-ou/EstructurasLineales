using EstructurasLineales.Estructuras.Estaticas;

namespace EstructurasLineales.Controles;

// Pila estática (Push, Pop, Peek, isEmpty, isFull) sobre un arreglo fijo
public partial class PilaEstaticaControl : UserControl
{
    private PilaEstatica<string> _pila = new(5);

    public PilaEstaticaControl()
    {
        InitializeComponent();
        CrearPila();
    }

    private void CrearPila()
    {
        _pila = new PilaEstatica<string>((int)nudCapacidad.Value);
        Registrar($"Pila creada con capacidad {_pila.Capacidad} (top = {_pila.Top}).");
        Actualizar();
    }

    private void Actualizar()
    {
        lstPila.BeginUpdate();
        lstPila.Items.Clear();
        for (int i = _pila.Capacidad - 1; i >= 0; i--)
        {
            string contenido = i <= _pila.Top ? _pila.ObtenerEn(i) : "(vacío)";
            string marca = i == _pila.Top ? "   ◄ TOP" : string.Empty;
            lstPila.Items.Add($"[{i}]  {contenido}{marca}");
        }
        lstPila.EndUpdate();

        lblEstado.Text =
            $"Elementos: {_pila.Count} de {_pila.Capacidad}{Environment.NewLine}" +
            $"top = {_pila.Top}{Environment.NewLine}" +
            $"isEmpty = {_pila.IsEmpty()}  |  isFull = {_pila.IsFull()}";
    }

    private void Registrar(string mensaje)
    {
        txtBitacora.AppendText($"{DateTime.Now:HH:mm:ss}  {mensaje}{Environment.NewLine}");
    }

    private void MostrarError(string mensaje)
    {
        Registrar("ERROR: " + mensaje);
        MessageBox.Show(mensaje, "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btnCrear_Click(object? sender, EventArgs e) => CrearPila();

    private void btnPush_Click(object? sender, EventArgs e)
    {
        string texto = txtElemento.Text.Trim();
        if (texto.Length == 0)
        {
            MessageBox.Show("Escribe un elemento para insertar.", "Falta el elemento",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtElemento.Focus();
            return;
        }

        try
        {
            _pila.Push(texto);
            Registrar($"Push(\"{texto}\")  → top = {_pila.Top}");
            txtElemento.Clear();
            txtElemento.Focus();
        }
        catch (InvalidOperationException ex)
        {
            MostrarError(ex.Message);
        }
        Actualizar();
    }

    private void btnPop_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _pila.Pop();
            Registrar($"Pop()  → \"{valor}\"  | top = {_pila.Top}");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError(ex.Message);
        }
        Actualizar();
    }

    private void btnPeek_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _pila.Peek();
            Registrar($"Peek()  → \"{valor}\"  (no se extrae)");
            MessageBox.Show($"Elemento en el tope: {valor}", "Peek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MostrarError(ex.Message);
        }
    }

    private void btnIsEmpty_Click(object? sender, EventArgs e)
    {
        bool vacia = _pila.IsEmpty();
        Registrar($"isEmpty()  → {vacia}");
        MessageBox.Show(vacia ? "La pila está vacía." : "La pila NO está vacía.", "isEmpty",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnIsFull_Click(object? sender, EventArgs e)
    {
        bool llena = _pila.IsFull();
        Registrar($"isFull()  → {llena}");
        MessageBox.Show(llena ? "La pila está llena." : "La pila NO está llena.", "isFull",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void txtElemento_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            btnPush.PerformClick();
        }
    }
}
