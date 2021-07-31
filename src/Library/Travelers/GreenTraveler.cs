
// SRP: Esta clase tiene la responsabilidad de definir un jugador verde. 

// OCP: Esta clase es un ejemplo del agregado de un jugador heredando la interface IExperience.

// LSP: Esta clase es subtipo de AbstractTraveler por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de clases de alto nivel.

namespace Library
{
    public class GreenTraveler : AbstractTraveler
    {
        public GreenTraveler(string name)
        :base(name)
        {
        }
    }
}