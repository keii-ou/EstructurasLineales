using EstructurasLineales.Estructuras.Estaticas;

namespace EstructurasLineales.Controles;

// Cola simple y cola circular con memoria estática (front / rear)
public partial class ColasEstaticasControl : UserControl
{
    private ColaSimpleEstatica<string> _simple = new(5);
    private ColaCircularEstatica<string> _circular = new(5);

    public ColasEstaticasControl()
    {
        InitializeComponent();
        CrearColas();
    }

    private void CrearColas()
    {
        int capacidad = (int)nudCapacidad.Value;
        _simple = new ColaSimpleEstatica<string>(capacidad);
        _circular = new ColaCircularEstatica<string>(capacidad);
        Registrar($"Colas creadas con capacidad {capacidad}.");
        Actualizar();
    }

    private void Registrar(string mensaje)
    {
        txtBitacora.AppendText($"{DateTime.Now:HH:mm:ss}  {mensaje}{Environment.NewLine}");
    }

    private void MostrarError(string cola, string mensaje)
    {
        Registrar($"ERROR ({cola}): {mensaje}");
        MessageBox.Show(mensaje, $"Cola {cola}: operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void Actualizar()
    {
        // ---- Cola simple
        lstSimple.BeginUpdate();
        lstSimple.Items.Clear();
        for (int i = 0; i < _simple.Capacidad; i++)
        {
            string contenido;
            if (_simple.EstaOcupada(i)) contenido = _simple.ObtenerEn(i);
            else if (!_simple.IsEmpty() && i < _simple.Front) contenido = "(libre, pero desperdiciada)";
            else contenido = "(vacío)";

            string marcas = string.Empty;
            if (!_simple.IsEmpty() && i == _simple.Front) marcas += "  ◄ FRONT";
            if (!_simple.IsEmpty() && i == _simple.Rear) marcas += "  ◄ REAR";
            lstSimple.Items.Add($"[{i}]  {contenido}{marcas}");
        }
        lstSimple.EndUpdate();
        lblSimpleInfo.Text =
            $"front = {_simple.Front}  |  rear = {_simple.Rear}  |  elementos = {_simple.Count}/{_simple.Capacidad}{Environment.NewLine}" +
            $"Espacio desperdiciado: {_simple.EspacioDesperdiciado} casilla(s)";

        // ---- Cola circular
        lstCircular.BeginUpdate();
        lstCircular.Items.Clear();
        for (int i = 0; i < _circular.Capacidad; i++)
        {
            string contenido = _circular.EstaOcupada(i) ? _circular.ObtenerEn(i) : "(vacío)";
            string marcas = string.Empty;
            if (_circular.EstaOcupada(i) && i == _circular.Front) marcas += "  ◄ FRONT";
            if (_circular.EstaOcupada(i) && i == _circular.Rear) marcas += "  ◄ REAR";
            lstCircular.Items.Add($"[{i}]  {contenido}{marcas}");
        }
        lstCircular.EndUpdate();
        lblCircularInfo.Text =
            $"front = {_circular.Front}  |  rear = {_circular.Rear}  |  elementos = {_circular.Count}/{_circular.Capacidad}{Environment.NewLine}" +
            $"Siguiente rear = (rear + 1) % {_circular.Capacidad} = {(_circular.Rear + 1) % _circular.Capacidad}";
    }

    private void btnCrear_Click(object? sender, EventArgs e) => CrearColas();

    // ====================================================== COLA SIMPLE
    private void btnSimpleEnqueue_Click(object? sender, EventArgs e)
    {
        string texto = txtSimple.Text.Trim();
        if (texto.Length == 0)
        {
            MessageBox.Show("Escribe un elemento para encolar.", "Falta el elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSimple.Focus();
            return;
        }

        try
        {
            _simple.Enqueue(texto);
            Registrar($"[Simple] Enqueue(\"{texto}\")  → rear = {_simple.Rear}");
            txtSimple.Clear();
            txtSimple.Focus();
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("simple", ex.Message);
        }
        Actualizar();
    }

    private void btnSimpleDequeue_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _simple.Dequeue();
            Registrar($"[Simple] Dequeue()  → \"{valor}\"  | front = {_simple.Front}");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("simple", ex.Message);
        }
        Actualizar();
    }

    private void btnSimplePeek_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _simple.Peek();
            Registrar($"[Simple] Peek()  → \"{valor}\"");
            MessageBox.Show($"Elemento al frente: {valor}", "Peek (cola simple)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("simple", ex.Message);
        }
    }

    private void btnSimpleIsEmpty_Click(object? sender, EventArgs e)
    {
        bool r = _simple.IsEmpty();
        Registrar($"[Simple] isEmpty()  → {r}");
        MessageBox.Show(r ? "La cola simple está vacía." : "La cola simple NO está vacía.", "isEmpty", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSimpleIsFull_Click(object? sender, EventArgs e)
    {
        bool r = _simple.IsFull();
        Registrar($"[Simple] isFull()  → {r}");
        MessageBox.Show(r ? "La cola simple está llena (rear llegó al final)." : "La cola simple NO está llena.", "isFull",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ====================================================== COLA CIRCULAR
    private void btnCircularEnqueue_Click(object? sender, EventArgs e)
    {
        string texto = txtCircular.Text.Trim();
        if (texto.Length == 0)
        {
            MessageBox.Show("Escribe un elemento para encolar.", "Falta el elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCircular.Focus();
            return;
        }

        try
        {
            _circular.Enqueue(texto);
            Registrar($"[Circular] Enqueue(\"{texto}\")  → rear = {_circular.Rear}");
            txtCircular.Clear();
            txtCircular.Focus();
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("circular", ex.Message);
        }
        Actualizar();
    }

    private void btnCircularDequeue_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _circular.Dequeue();
            Registrar($"[Circular] Dequeue()  → \"{valor}\"  | front = {_circular.Front}");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("circular", ex.Message);
        }
        Actualizar();
    }

    private void btnCircularPeek_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _circular.Peek();
            Registrar($"[Circular] Peek()  → \"{valor}\"");
            MessageBox.Show($"Elemento al frente: {valor}", "Peek (cola circular)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MostrarError("circular", ex.Message);
        }
    }

    private void btnCircularIsEmpty_Click(object? sender, EventArgs e)
    {
        bool r = _circular.IsEmpty();
        Registrar($"[Circular] isEmpty()  → {r}");
        MessageBox.Show(r ? "La cola circular está vacía." : "La cola circular NO está vacía.", "isEmpty", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnCircularIsFull_Click(object? sender, EventArgs e)
    {
        bool r = _circular.IsFull();
        Registrar($"[Circular] isFull()  → {r}");
        MessageBox.Show(r ? "La cola circular está llena (todas las casillas ocupadas)." : "La cola circular NO está llena.", "isFull",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
