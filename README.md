# Unidad 3 – Estructuras lineales (C# · Windows Forms · .NET 10)

Proyecto de Visual Studio con la interfaz construida en el **diseñador** (cada pestaña es un `UserControl` con su
`.Designer.cs`) y las estructuras de datos programadas desde cero.

## Cómo abrirlo
1. Visual Studio 2022/2026 con la carga de trabajo **Desarrollo de escritorio con .NET** y el SDK de **.NET 10**.
2. Abrir `EstructurasLineales.sln` y presionar **F5**.
3. Para abrir el diseñador: doble clic en `MainForm.cs` o en cualquier archivo de `Controles/` (compilar antes con Ctrl+Shift+B).

## Estructura
| Carpeta / archivo | Contenido | Tarea |
|---|---|---|
| `Estructuras/Estaticas/PilaEstatica.cs` | Pila con arreglo fijo y puntero `top` (Push, Pop, Peek, isEmpty, isFull) | 3.1 |
| `Estructuras/Estaticas/ColaSimpleEstatica.cs` | Cola lineal con `front` / `rear` (muestra el espacio desperdiciado) | 3.1 |
| `Estructuras/Estaticas/ColaCircularEstatica.cs` | Cola circular con aritmética modular | 3.1 |
| `Estructuras/Dinamicas/Nodo.cs`, `ListaEnlazada.cs` | Nodo genérico y lista enlazada simple | 3.2 |
| `Estructuras/Dinamicas/PilaDinamica.cs`, `ColaDinamica.cs` | Pila y cola genéricas con nodos | 3.2 |
| `Estructuras/Dinamicas/ColaPrioridad.cs` | Cola de prioridad (lista ordenada) | 3.3 |
| `Controles/*Control.cs` + `.Designer.cs` | Una pestaña por tema | 3.1 – 3.3 |
| `Modelos/Vuelo.cs` | Modelo del caso práctico (despacho de aviones) | 3.3 |

Las estructuras **no usan** `List<T>`, `Stack<T>`, `Queue<T>` ni `LinkedList<T>`. Esas colecciones nativas solo aparecen en la
pestaña *Estático vs dinámico*, como referencia en la prueba de rendimiento.

## Pruebas sugeridas para las capturas
- **Pila estática**: capacidad 3 → Push A, B, C, D (desbordamiento) → Pop ×4 (subdesbordamiento).
- **Colas estáticas**: capacidad 5 → Enqueue ×5 → Dequeue ×2 → Enqueue: la simple dice «llena», la circular sigue aceptando.
- **Lista enlazada**: agregar al inicio/final, insertar en índice, buscar, invertir y eliminar.
- **Estático vs dinámico**: N = 100 000 y 1 000 000 en modo Release (Ctrl+F5).
- **Despacho de aviones**: generar 5 aleatorios, solicitar una *Emergencia* y comprobar que pasa al frente.
