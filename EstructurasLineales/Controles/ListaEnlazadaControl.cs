using System.Text;
using EstructurasLineales.Estructuras.Dinamicas;

namespace EstructurasLineales.Controles;

//Tarea 3.2 – Lista enlazada simple con nodos dinámicos
public partial class ListaEnlazadaControl : UserControl
{
    private readonly ListaEnlazada<string> _lista = new();

    public ListaEnlazadaControl()
    {
        InitializeComponent();
        Actualizar();
    }

    private void Actualizar()
    {
        var cadena = new StringBuilder("CABEZA → ");
        lstNodos.BeginUpdate();
        lstNodos.Items.Clear();

        int i = 0;
        foreach (string dato in _lista)
        {
            cadena.Append($"[{dato}] → ");
            string marca = i == 0 ? "   ◄ CABEZA" : string.Empty;
            if (i == _lista.Count - 1) marca += "   ◄ COLA";
            lstNodos.Items.Add($"Nodo {i}:  {dato}{marca}");
            i++;
        }
        lstNodos.EndUpdate();

        cadena.Append("null");
        lblCadena.Text = cadena.ToString();
        lblEstado.Text = $"Nodos en memoria: {_lista.Count}{Environment.NewLine}isEmpty = {_lista.IsEmpty()}";
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

    //Lee el valor escrito; si está vacío avisa y devuelve null.
    private string? LeerValor()
    {
        string texto = txtValor.Text.Trim();
        if (texto.Length == 0)
        {
            MessageBox.Show("Escribe un valor.", "Falta el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtValor.Focus();
            return null;
        }
        return texto;
    }

    private void btnAgregarInicio_Click(object? sender, EventArgs e)
    {
        string? valor = LeerValor();
        if (valor == null) return;

        _lista.AgregarAlInicio(valor);
        Registrar($"AgregarAlInicio(\"{valor}\")  O(1)");
        txtValor.Clear();
        Actualizar();
    }

    private void btnAgregarFinal_Click(object? sender, EventArgs e)
    {
        string? valor = LeerValor();
        if (valor == null) return;

        _lista.AgregarAlFinal(valor);
        Registrar($"AgregarAlFinal(\"{valor}\")  O(1)");
        txtValor.Clear();
        Actualizar();
    }

    private void btnInsertar_Click(object? sender, EventArgs e)
    {
        string? valor = LeerValor();
        if (valor == null) return;

        try
        {
            int indice = (int)nudIndice.Value;
            _lista.Insertar(indice, valor);
            Registrar($"Insertar({indice}, \"{valor}\")  O(n)");
            txtValor.Clear();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MostrarError(ex.Message.Split(Environment.NewLine)[0]);
        }
        Actualizar();
    }

    private void btnEliminarPrimero_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _lista.EliminarPrimero();
            Registrar($"EliminarPrimero()  → \"{valor}\"  O(1)");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError(ex.Message);
        }
        Actualizar();
    }

    private void btnEliminarUltimo_Click(object? sender, EventArgs e)
    {
        try
        {
            string valor = _lista.EliminarUltimo();
            Registrar($"EliminarUltimo()  → \"{valor}\"  O(n) en lista simple");
        }
        catch (InvalidOperationException ex)
        {
            MostrarError(ex.Message);
        }
        Actualizar();
    }

    private void btnEliminarEn_Click(object? sender, EventArgs e)
    {
        try
        {
            int indice = (int)nudIndice.Value;
            string valor = _lista.EliminarEn(indice);
            Registrar($"EliminarEn({indice})  → \"{valor}\"  O(n)");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MostrarError(ex.Message.Split(Environment.NewLine)[0]);
        }
        Actualizar();
    }

    private void btnBuscar_Click(object? sender, EventArgs e)
    {
        string? valor = LeerValor();
        if (valor == null) return;

        int posicion = _lista.Buscar(valor);
        Registrar($"Buscar(\"{valor}\")  → {(posicion >= 0 ? "índice " + posicion : "no encontrado")}");
        MessageBox.Show(posicion >= 0 ? $"\"{valor}\" está en el índice {posicion}." : $"\"{valor}\" no existe en la lista.",
            "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnObtener_Click(object? sender, EventArgs e)
    {
        try
        {
            int indice = (int)nudIndice.Value;
            string valor = _lista.Obtener(indice);
            Registrar($"Obtener({indice})  → \"{valor}\"  O(n)");
            MessageBox.Show($"Índice {indice}: {valor}", "Obtener", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MostrarError(ex.Message.Split(Environment.NewLine)[0]);
        }
    }

    private void btnInvertir_Click(object? sender, EventArgs e)
    {
        _lista.Invertir();
        Registrar("Invertir()  → se reorientaron las referencias, sin crear nodos nuevos  O(n)");
        Actualizar();
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        _lista.Limpiar();
        Registrar("Limpiar()  → la lista queda vacía");
        Actualizar();
    }
}
