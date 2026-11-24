using System.Collections;

namespace EstructurasLineales.Estructuras.Dinamicas;

/// Pila (LIFO) genérica con nodos dinámicos. El tope es el primer nodo de la cadena:
/// Push y Pop solo cambian esa referencia, por lo que son O(1). Nunca se llena.

public class PilaDinamica<T> : IEnumerable<T>
{
    private Nodo<T>? _tope;

    public int Count { get; private set; }

    public bool IsEmpty() => _tope == null;

    public void Push(T elemento)
    {
        var nuevo = new Nodo<T>(elemento);
        nuevo.Siguiente = _tope;
        _tope = nuevo;
        Count++;
    }

    public T Pop()
    {
        if (_tope == null)
            throw new InvalidOperationException("Subdesbordamiento (underflow): la pila está vacía.");

        T dato = _tope.Dato;
        _tope = _tope.Siguiente;
        Count--;
        return dato;
    }

    public T Peek()
    {
        if (_tope == null)
            throw new InvalidOperationException("La pila está vacía: no hay elemento en el tope.");

        return _tope.Dato;
    }

    public void Limpiar()
    {
        _tope = null;
        Count = 0;
    }

    //Recorre desde el tope hasta la base
    public IEnumerator<T> GetEnumerator()
    {
        Nodo<T>? actual = _tope;
        while (actual != null)
        {
            yield return actual.Dato;
            actual = actual.Siguiente;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
