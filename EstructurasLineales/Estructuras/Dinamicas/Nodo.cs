namespace EstructurasLineales.Estructuras.Dinamicas;


// Nodo dinámico: guarda un dato y una referencia (puntero) al nodo siguiente.
//Cada nodo se crea con new en el montón (heap) y se enlaza en tiempo de ejecución.

public class Nodo<T>
{
    public T Dato { get; set; }
    public Nodo<T>? Siguiente { get; set; }

    public Nodo(T dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}
