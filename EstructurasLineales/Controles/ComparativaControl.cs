using System.Diagnostics;
using EstructurasLineales.Estructuras.Dinamicas;
using EstructurasLineales.Estructuras.Estaticas;

namespace EstructurasLineales.Controles;


//Comparativa práctica: estructuras estáticas (arreglo) vs dinámicas (nodos)
//vs colecciones nativas de .NET (solo como referencia en esta prueba de rendimiento).

public partial class ComparativaControl : UserControl
{
    public ComparativaControl()
    {
        InitializeComponent();

        lblConclusion.Text =
            "• Estática (arreglo): reserva toda la capacidad desde el inicio. No tiene sobrecarga por elemento, pero si la capacidad se " +
            "sobredimensiona (fila «2N») la mitad de la memoria se desperdicia, y si se queda corta hay desbordamiento." + Environment.NewLine +
            "• Dinámica (nodos): usa exactamente los nodos necesarios, pero cada nodo agrega encabezado de objeto + referencia al siguiente " +
            "(≈ 32 bytes por nodo de int en 64 bits frente a 4 bytes en el arreglo), una asignación en el montón por elemento, más trabajo para el " +
            "recolector de basura y peor localidad de caché." + Environment.NewLine +
            "• Push/Pop/Enqueue/Dequeue son O(1) en todas; la diferencia está en las constantes, la memoria y la flexibilidad." + Environment.NewLine +
            "• Stack<T> y Queue<T> nativas usan un arreglo que se redimensiona: combinan lo mejor de ambos mundos (en esta práctica solo sirven de referencia).";
    }

    private void btnComparar_Click(object? sender, EventArgs e)
    {
        int n = (int)nudN.Value;
        btnComparar.Enabled = false;
        Cursor = Cursors.WaitCursor;
        lvResultados.Items.Clear();

        try
        {
            // ---------------- Pilas
            Agregar("Pila estática (capacidad = N)", n, Medir(n,
                cant => { var p = new PilaEstatica<int>(cant); for (int i = 0; i < cant; i++) p.Push(i); return p; },
                o => { var p = (PilaEstatica<int>)o; while (!p.IsEmpty()) p.Pop(); }));

            Agregar("Pila estática (capacidad = 2N, mitad vacía)", n, Medir(n,
                cant => { var p = new PilaEstatica<int>(cant * 2); for (int i = 0; i < cant; i++) p.Push(i); return p; },
                o => { var p = (PilaEstatica<int>)o; while (!p.IsEmpty()) p.Pop(); }));

            Agregar("Pila dinámica (nodos)", n, Medir(n,
                cant => { var p = new PilaDinamica<int>(); for (int i = 0; i < cant; i++) p.Push(i); return p; },
                o => { var p = (PilaDinamica<int>)o; while (!p.IsEmpty()) p.Pop(); }));

            Agregar("Stack<int> (nativa, referencia)", n, Medir(n,
                cant => { var p = new Stack<int>(); for (int i = 0; i < cant; i++) p.Push(i); return p; },
                o => { var p = (Stack<int>)o; while (p.Count > 0) p.Pop(); }));

            // ---------------- Colas
            Agregar("Cola circular estática (capacidad = N)", n, Medir(n,
                cant => { var c = new ColaCircularEstatica<int>(cant); for (int i = 0; i < cant; i++) c.Enqueue(i); return c; },
                o => { var c = (ColaCircularEstatica<int>)o; while (!c.IsEmpty()) c.Dequeue(); }));

            Agregar("Cola dinámica (nodos)", n, Medir(n,
                cant => { var c = new ColaDinamica<int>(); for (int i = 0; i < cant; i++) c.Enqueue(i); return c; },
                o => { var c = (ColaDinamica<int>)o; while (!c.IsEmpty()) c.Dequeue(); }));

            Agregar("Queue<int> (nativa, referencia)", n, Medir(n,
                cant => { var c = new Queue<int>(); for (int i = 0; i < cant; i++) c.Enqueue(i); return c; },
                o => { var c = (Queue<int>)o; while (c.Count > 0) c.Dequeue(); }));
        }
        finally
        {
            Cursor = Cursors.Default;
            btnComparar.Enabled = true;
        }
    }

    //Mide el tiempo de llenado, el de vaciado y la memoria retenida por la estructura llena
    private static (double InsercionMs, double ExtraccionMs, long Bytes) Medir(
        int n, Func<int, object> llenar, Action<object> vaciar)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        long antes = GC.GetTotalMemory(true);

        var cronometro = Stopwatch.StartNew();
        object estructura = llenar(n);
        cronometro.Stop();
        double insercion = cronometro.Elapsed.TotalMilliseconds;

        long bytes = Math.Max(0, GC.GetTotalMemory(true) - antes);

        cronometro.Restart();
        vaciar(estructura);
        cronometro.Stop();
        double extraccion = cronometro.Elapsed.TotalMilliseconds;

        GC.KeepAlive(estructura);
        return (insercion, extraccion, bytes);
    }

    private void Agregar(string nombre, int n, (double InsercionMs, double ExtraccionMs, long Bytes) r)
    {
        var fila = new ListViewItem(nombre);
        fila.SubItems.Add(r.InsercionMs.ToString("N2"));
        fila.SubItems.Add(r.ExtraccionMs.ToString("N2"));
        fila.SubItems.Add((r.Bytes / 1024.0).ToString("N0"));
        fila.SubItems.Add((r.Bytes / (double)n).ToString("N1"));
        lvResultados.Items.Add(fila);
        lvResultados.Refresh();
    }
}
