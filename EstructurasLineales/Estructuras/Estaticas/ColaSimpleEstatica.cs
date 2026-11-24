namespace EstructurasLineales.Estructuras.Estaticas;


// Cola simple (lineal, FIFO) con arreglo estático y punteros de índice front y rear.
// La cola puede reportar "llena" aunque haya espacio libre al inicio del arreglo.
// Solo se reinicia cuando queda completamente vacía.

public class ColaSimpleEstatica<T>
{
    private readonly T[] _datos;
    private int _front;
    private int _rear;

    public ColaSimpleEstatica(int capacidad)
    {
        if (capacidad <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacidad), "La capacidad debe ser mayor que cero.");

        _datos = new T[capacidad];
        _front = 0;
        _rear = -1;
    }

    public int Capacidad => _datos.Length;
    public int Front => _front;
    public int Rear => _rear;
    public int Count => IsEmpty() ? 0 : _rear - _front + 1;

    // Casillas libres al inicio del arreglo que no se pueden reutilizar.
    public int EspacioDesperdiciado => IsEmpty() ? 0 : _front;

    public bool IsEmpty() => _rear < _front;

    // La cola está "llena" cuando rear llega al último índice, aunque front > 0.
    public bool IsFull() => _rear == _datos.Length - 1;

    public void Enqueue(T elemento)
    {
        if (IsFull())
            throw new InvalidOperationException(
                "Cola llena: rear llegó al final del arreglo" +
                (EspacioDesperdiciado > 0 ? $" (hay {EspacioDesperdiciado} casilla(s) libres desperdiciadas al inicio)." : "."));

        _rear++;
        _datos[_rear] = elemento;
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");

        T elemento = _datos[_front];
        _datos[_front] = default!;
        _front++;

        // Si ya no quedan elementos, se reinician los punteros.
        if (_front > _rear)
        {
            _front = 0;
            _rear = -1;
        }

        return elemento;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");

        return _datos[_front];
    }

    public bool EstaOcupada(int indice) => !IsEmpty() && indice >= _front && indice <= _rear;

    public T ObtenerEn(int indice)
    {
        if (indice < 0 || indice >= _datos.Length)
            throw new ArgumentOutOfRangeException(nameof(indice));

        return _datos[indice];
    }
}
