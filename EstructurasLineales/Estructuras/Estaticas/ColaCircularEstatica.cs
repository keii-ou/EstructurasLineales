namespace EstructurasLineales.Estructuras.Estaticas;

// Cola circular (FIFO) con arreglo estático. Los punteros front y rear avanzan
// con aritmética modular, de modo que el espacio liberado por Dequeue se reutiliza.
// Se usa un contador para distinguir "llena" de "vacía" (ambas dejarían front y rear contiguos).

public class ColaCircularEstatica<T>
{
    private readonly T[] _datos;
    private int _front;
    private int _rear;
    private int _count;

    public ColaCircularEstatica(int capacidad)
    {
        if (capacidad <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacidad), "La capacidad debe ser mayor que cero.");

        _datos = new T[capacidad];
        _front = 0;
        _rear = -1;
        _count = 0;
    }

    public int Capacidad => _datos.Length;
    public int Front => _front;
    public int Rear => _rear;
    public int Count => _count;

    public bool IsEmpty() => _count == 0;
    public bool IsFull() => _count == _datos.Length;

    public void Enqueue(T elemento)
    {
        if (IsFull())
            throw new InvalidOperationException("Cola llena: no hay ninguna casilla libre en el anillo.");

        _rear = (_rear + 1) % _datos.Length;
        _datos[_rear] = elemento;
        _count++;
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");

        T elemento = _datos[_front];
        _datos[_front] = default!;
        _front = (_front + 1) % _datos.Length;
        _count--;
        return elemento;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");

        return _datos[_front];
    }

    //¿La casilla paramref name="indice" contiene un elemento vigente?
    public bool EstaOcupada(int indice)
    {
        if (_count == 0) return false;
        int distancia = (indice - _front + _datos.Length) % _datos.Length;
        return distancia < _count;
    }

    public T ObtenerEn(int indice)
    {
        if (indice < 0 || indice >= _datos.Length)
            throw new ArgumentOutOfRangeException(nameof(indice));

        return _datos[indice];
    }
}
