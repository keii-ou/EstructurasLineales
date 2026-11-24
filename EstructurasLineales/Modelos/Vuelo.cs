namespace EstructurasLineales.Modelos;

//Tipo de operación; el valor numérico es la prioridad (1 = más urgente)
public enum TipoVuelo
{
    Emergencia = 1,
    Comercial = 2,
    Carga = 3,
    Privado = 4
}

// Solicitud de pista de un avión.
public sealed record Vuelo(string Codigo, TipoVuelo Tipo, DateTime Solicitud)
{
    public int Prioridad => (int)Tipo;
}
