using EstructurasLineales.Estructuras.Dinamicas;

namespace EstructurasLineales.Controles;

//Pila y cola con nodos dinámicos (sin capacidad fija)
public partial class PilaColaDinamicaControl : UserControl
{
    private readonly PilaDinamica<string> _pila = new();
    private readonly ColaDinamica<string> _cola = new();
    private int _contadorPila;
    private int _contadorCola;

    public PilaColaDinamicaControl()
    {
        InitializeComponent();
        Actualizar();
    }

    private void Registrar(string mensaje)
    {
        txtBitacora.AppendText($"{DateTime.Now:HH:mm:ss}  {mensaje}{Environment.NewLine}");
    }

    private void MostrarError(string estructura, string mensaje)
    {
        Registrar($"ERROR ({estructura}): {mensaje}");
        MessageBox.Show(mensaje, $"{estructura}: operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void Actualizar()
    {
        lstPila.BeginUpdate();
        lstPila.Items.Clear();
        int i = 0;
        foreach (string dato in _pila)
        {
            lstPila.Items.Add($"[{dato}]{(i == 0 ? "   ◄ TOPE" : string.Empty)}");
            i++;
        }
        lstPila.EndUpdate();
        lblPilaInfo.Text = $"Nodos: {_pila.Count}  |  isEmpty = {_pila.IsEmpty()}{Environment.NewLine}Nunca se llena (sin isFull)";

        lstCola.BeginUpdate();
        lstCola.Items.Clear();
        i = 0;
        foreach (string dato in _cola)
        {
            string marca = i == 0 ? "   ◄ FRENTE" : string.Empty;
            if (i == _cola.Count - 1) marca += "   ◄ FINAL";
            lstCola.Items.Add($"[{dato}]{marca}");
            i++;
        }
        lstCola.EndUpdate();
        lblColaInfo.Text = $"Nodos: {_cola.Count}  |  isEmpty = {_cola.IsEmpty()}{Environment.NewLine}Nunca se llena (sin isFull)";
    }

    // ====================================================== PILA DINÁMICA
    private void btnPilaPush_Click(object? sender, EventArgs e)
    {
        string texto = txtPila.Text.Trim();
        if (texto.Length == 0)
        {
            MessageBox.Show("Escribe un elemento.", "Falta el elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPila.Focus();
            return;
        }
        _pila.Push(texto);
        Registrar($"[Pila] Push(\"{texto}\")  → nodos = {_pila.Count}");
        txtPila.Clear();
        txtPila.Focus();
        Actualizar();
    }

    private void btnPilaPop_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _pila.Pop();
            Registrar($"[Pila] Pop()  → \"{valor}\"  | nodos = {_pila.Count}");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("Pila", ex.Message);
        }
        Actualizar();
    }

    private void btnPilaPeek_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _pila.Peek();
            Registrar($"[Pila] Peek()  → \"{valor}\"");
            MessageBox.Show($"Elemento en el tope: {valor}", "Peek (pila dinámica)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("Pila", ex.Message);
        }
    }

    private void btnPilaIsEmpty_Click(object? sender, EventArgs e)
    {
        bool r = _pila.IsEmpty();
        Registrar($"[Pila] isEmpty()  → {r}");
        MessageBox.Show(r ? "La pila está vacía." : "La pila NO está vacía.", "isEmpty", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnPilaMasivo_Click(object? sender, EventArgs e)
    {
        for (int k = 0; k < 20; k++)
            _pila.Push($"P{++_contadorPila}");
        Registrar($"[Pila] Push ×20  → nodos = {_pila.Count} (no hay desbordamiento)");
        Actualizar();
    }

    // ====================================================== COLA DINÁMICA
    private void btnColaEnqueue_Click(object? sender, EventArgs e)
    {
        string texto = txtCola.Text.Trim();
        if (texto.Length == 0)
        {
            MessageBox.Show("Escribe un elemento.", "Falta el elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCola.Focus();
            return;
        }
        _cola.Enqueue(texto);
        Registrar($"[Cola] Enqueue(\"{texto}\")  → nodos = {_cola.Count}");
        txtCola.Clear();
        txtCola.Focus();
        Actualizar();
    }

    private void btnColaDequeue_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _cola.Dequeue();
            Registrar($"[Cola] Dequeue()  → \"{valor}\"  | nodos = {_cola.Count}");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("Cola", ex.Message);
        }
        Actualizar();
    }

    private void btnColaPeek_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _cola.Peek();
            Registrar($"[Cola] Peek()  → \"{valor}\"");
            MessageBox.Show($"Elemento al frente: {valor}", "Peek (cola dinámica)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("Cola", ex.Message);
        }
    }

    private void btnColaIsEmpty_Click(object? sender, EventArgs e)
    {
        bool r = _cola.IsEmpty();
        Registrar($"[Cola] isEmpty()  → {r}");
        MessageBox.Show(r ? "La cola está vacía." : "La cola NO está vacía.", "isEmpty", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnColaMasivo_Click(object? sender, EventArgs e)
    {
        for (int k = 0; k < 20; k++)
            _cola.Enqueue($"C{++_contadorCola}");
        Registrar($"[Cola] Enqueue ×20  → nodos = {_cola.Count} (sin límite de capacidad)");
        Actualizar();
    }
}
