namespace EstructurasLineales.Estructuras.Estaticas;


// Pila (LIFO) programada desde cero con un arreglo estático de tamaño fijo.
// No se usa ninguna colección nativa (List, Stack, etc.).
// El puntero de índice top apunta al último elemento insertado (-1 = pila vacía).
public class PilaEstatica<T>
{
    private readonly T[] _datos;
    private int _top;

    public PilaEstatica(int capacidad)
    {
        if (capacidad <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacidad), "La capacidad debe ser mayor que cero.");

        _datos = new T[capacidad];
        _top = -1;
    }

    // Tamaño fijo del arreglo (se decide al crear la pila).
    public int Capacidad => _datos.Length;

    // Índice del último elemento insertado; -1 si la pila está vacía.  
    public int Top => _top;

    // Cantidad de elementos almacenados.
    public int Count => _top + 1;

    // ¿La pila no tiene elementos?  O(1)
    public bool IsEmpty() => _top == -1;

    // ¿El arreglo está completamente ocupado?  O(1)
    public bool IsFull() => _top == _datos.Length - 1;

    // Inserta un elemento en el tope.  O(1)
    // <exception cref="InvalidOperationException">Desbordamiento (overflow) si la pila está llena.
    public void Push(T elemento)
    {
        if (IsFull())
            throw new InvalidOperationException("Desbordamiento (overflow): la pila está llena.");

        _top++;
        _datos[_top] = elemento;
    }

    // Extrae y devuelve el elemento del tope.  O(1)
    // <exception cref="InvalidOperationException">Subdesbordamiento (underflow) si la pila está vacía.</exception>
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la pila está vacía.");

        T elemento = _datos[_top];
        _datos[_top] = default!;   // libera la referencia para el recolector de basura
        _top--;
        return elemento;
    }

    // Devuelve el elemento del tope sin extraerlo.  O(1)
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La pila está vacía: no hay elemento en el tope.");

        return _datos[_top];
    }

    // Lee la casilla <paramref name="indice"/> del arreglo (solo para visualización).
    public T ObtenerEn(int indice)
    {
        if (indice < 0 || indice >= _datos.Length)
            throw new ArgumentOutOfRangeException(nameof(indice));

        return _datos[indice];
    }
}
