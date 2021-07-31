
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de paisaje.

// ISP: Esta interface define una sola operacion para que el cliente no dependa de tipos que no se usa.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

// Polimorfismo: La operacion definida es polimorfica a todos los paisajes.

namespace Library
{
    public interface ILandscape : IExperience
    {
        public int NextValueBenefict(AbstractTraveler traveler);
    }
}