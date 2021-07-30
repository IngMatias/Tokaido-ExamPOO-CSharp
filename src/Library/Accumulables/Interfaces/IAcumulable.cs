
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de moneda.

// ISP: Esta interface define una sola operacion para que el cliente no dependa de tipos que no se usa.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

// Polimorfismo: Value es una propiedad polimorfica a todos los IAcumulables.

namespace Library
{
    public interface IAcumulable
    {
        public int Value {get; }
    }
}