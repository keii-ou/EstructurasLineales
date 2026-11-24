using System.Collections;

namespace EstructurasLineales.Estructuras.Dinamicas;


// Cola (FIFO) genérica con nodos dinámicos. Mantiene referencias al frente y al final,
// de modo que Enqueue y Dequeue son O(1). Nunca se llena y no desperdicia casillas.

public class ColaDinamica<T> : IEnumerable<T>
{
    private Nodo<T>? _frente;
    private Nodo<T>? _final;

    public int Count { get; private set; }

    public bool IsEmpty() => _frente == null;

    public void Enqueue(T elemento)
    {
        var nuevo = new Nodo<T>(elemento);
        if (_final == null)
        {
            _frente = nuevo;
            _final = nuevo;
        }
        else
        {
            _final.Siguiente = nuevo;
            _final = nuevo;
        }
        Count++;
    }

    public T Dequeue()
    {
        if (_frente == null)
            throw new InvalidOperationException("La cola está vacía.");

        T dato = _frente.Dato;
        _frente = _frente.Siguiente;
        if (_frente == null) _final = null;
        Count--;
        return dato;
    }

    public T Peek()
    {
        if (_frente == null)
            throw new InvalidOperationException("La cola está vacía.");

        return _frente.Dato;
    }

    public void Limpiar()
    {
        _frente = null;
        _final = null;
        Count = 0;
    }

    //Recorre desde el frente hasta el final
    public IEnumerator<T> GetEnumerator()
    {
        Nodo<T>? actual = _frente;
        while (actual != null)
        {
            yield return actual.Dato;
            actual = actual.Siguiente;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
