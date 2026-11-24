namespace EstructurasLineales.Estructuras.Dinamicas;


/// Cola de prioridad con lista enlazada ordenada. Un número menor significa mayor prioridad.
/// Los elementos con la misma prioridad se atienden por orden de llegada (FIFO).


public class ColaPrioridad<T>
{
    private sealed class NodoPrioridad
    {
        public T Dato { get; }
        public int Prioridad { get; }
        public NodoPrioridad? Siguiente { get; set; }

        public NodoPrioridad(T dato, int prioridad)
        {
            Dato = dato;
            Prioridad = prioridad;
        }
    }

    private NodoPrioridad? _frente;

    public int Count { get; private set; }

    public bool IsEmpty() => _frente == null;

    public void Enqueue(T dato, int prioridad)
    {
        var nuevo = new NodoPrioridad(dato, prioridad);

        if (_frente == null || prioridad < _frente.Prioridad)
        {
            // Pasa al frente: es más urgente que todos los que esperan.
            nuevo.Siguiente = _frente;
            _frente = nuevo;
        }
        else
        {
            // Se coloca detrás del último con prioridad igual o más urgente (mantiene FIFO por nivel).
            NodoPrioridad actual = _frente;
            while (actual.Siguiente != null && actual.Siguiente.Prioridad <= prioridad)
                actual = actual.Siguiente;

            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
        }

        Count++;
    }

    public T Dequeue()
    {
        if (_frente == null)
            throw new InvalidOperationException("La cola de prioridad está vacía.");

        T dato = _frente.Dato;
        _frente = _frente.Siguiente;
        Count--;
        return dato;
    }

    public T Peek()
    {
        if (_frente == null)
            throw new InvalidOperationException("La cola de prioridad está vacía.");

        return _frente.Dato;
    }

    public void Limpiar()
    {
        _frente = null;
        Count = 0;
    }

    //Recorre en orden de atención, con su prioridad
    public IEnumerable<(T Dato, int Prioridad)> Elementos()
    {
        NodoPrioridad? actual = _frente;
        while (actual != null)
        {
            yield return (actual.Dato, actual.Prioridad);
            actual = actual.Siguiente;
        }
    }
}
