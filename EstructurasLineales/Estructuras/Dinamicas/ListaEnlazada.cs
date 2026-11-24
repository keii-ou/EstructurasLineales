using System.Collections;

namespace EstructurasLineales.Estructuras.Dinamicas;


// Lista enlazada simple genérica con nodos dinámicos. Mantiene referencias a la cabeza y a la cola

public class ListaEnlazada<T> : IEnumerable<T>
{
    private Nodo<T>? _cabeza;
    private Nodo<T>? _cola;

    public int Count { get; private set; }

    public bool IsEmpty() => _cabeza == null;

    /// <summary>Inserta al inicio.  O(1)</summary>
    public void AgregarAlInicio(T dato)
    {
        var nuevo = new Nodo<T>(dato);
        nuevo.Siguiente = _cabeza;
        _cabeza = nuevo;
        if (_cola == null) _cola = nuevo;
        Count++;
    }

    //Inserta al final.  O(1) gracias a la referencia a la cola
    public void AgregarAlFinal(T dato)
    {
        var nuevo = new Nodo<T>(dato);
        if (_cola == null)
        {
            _cabeza = nuevo;
            _cola = nuevo;
        }
        else
        {
            _cola.Siguiente = nuevo;
            _cola = nuevo;
        }
        Count++;
    }

    //Inserta en la posición indicada (0..Count).  O(n)
    public void Insertar(int indice, T dato)
    {
        if (indice < 0 || indice > Count)
            throw new ArgumentOutOfRangeException(nameof(indice), $"El índice debe estar entre 0 y {Count}.");

        if (indice == 0) { AgregarAlInicio(dato); return; }
        if (indice == Count) { AgregarAlFinal(dato); return; }

        Nodo<T> anterior = ObtenerNodo(indice - 1);
        var nuevo = new Nodo<T>(dato);
        nuevo.Siguiente = anterior.Siguiente;
        anterior.Siguiente = nuevo;
        Count++;
    }

    //Elimina y devuelve el primer elemento.  O(1)
    public T EliminarPrimero()
    {
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía.");

        T dato = _cabeza.Dato;
        _cabeza = _cabeza.Siguiente;
        if (_cabeza == null) _cola = null;
        Count--;
        return dato;
    }

    //Elimina y devuelve el último elemento.  O(n): en una lista simple hay que buscar al penúltimo.
    public T EliminarUltimo()
    {
        if (_cabeza == null || _cola == null)
            throw new InvalidOperationException("La lista está vacía.");

        T dato = _cola.Dato;

        if (_cabeza == _cola)
        {
            _cabeza = null;
            _cola = null;
        }
        else
        {
            Nodo<T> actual = _cabeza;
            while (actual.Siguiente != _cola)
                actual = actual.Siguiente!;

            actual.Siguiente = null;
            _cola = actual;
        }

        Count--;
        return dato;
    }

    //Elimina el elemento de la posición indicada y lo devuelve.  O(n)
    public T EliminarEn(int indice)
    {
        if (indice < 0 || indice >= Count)
            throw new ArgumentOutOfRangeException(nameof(indice), $"El índice debe estar entre 0 y {Count - 1}.");

        if (indice == 0) return EliminarPrimero();
        if (indice == Count - 1) return EliminarUltimo();

        Nodo<T> anterior = ObtenerNodo(indice - 1);
        Nodo<T> objetivo = anterior.Siguiente!;
        anterior.Siguiente = objetivo.Siguiente;
        Count--;
        return objetivo.Dato;
    }

    //Devuelve el elemento de la posición indicada.  O(n)
    public T Obtener(int indice)
    {
        if (indice < 0 || indice >= Count)
            throw new ArgumentOutOfRangeException(nameof(indice), $"El índice debe estar entre 0 y {Count - 1}.");

        return ObtenerNodo(indice).Dato;
    }

    //Devuelve el índice de la primera coincidencia o -1 si no existe.  O(n)
    public int Buscar(T dato)
    {
        int indice = 0;
        Nodo<T>? actual = _cabeza;
        while (actual != null)
        {
            if (EqualityComparer<T>.Default.Equals(actual.Dato, dato))
                return indice;
            actual = actual.Siguiente;
            indice++;
        }
        return -1;
    }

    //Invierte la lista reorientando las referencias, sin crear nodos nuevos.  O(n)
    public void Invertir()
    {
        Nodo<T>? previo = null;
        Nodo<T>? actual = _cabeza;
        _cola = _cabeza;

        while (actual != null)
        {
            Nodo<T>? siguiente = actual.Siguiente;
            actual.Siguiente = previo;
            previo = actual;
            actual = siguiente;
        }

        _cabeza = previo;
    }

    public void Limpiar()
    {
        _cabeza = null;
        _cola = null;
        Count = 0;
    }

    private Nodo<T> ObtenerNodo(int indice)
    {
        Nodo<T> actual = _cabeza!;
        for (int i = 0; i < indice; i++)
            actual = actual.Siguiente!;
        return actual;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Nodo<T>? actual = _cabeza;
        while (actual != null)
        {
            yield return actual.Dato;
            actual = actual.Siguiente;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
