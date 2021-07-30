
// SRP: Esta clase tiene la responsabilidad de contener un valor de un tipo de moneda.

// OCP: Esta clase es un ejemplo del agregado de una moneda implementando la interface IAcumulable.

// LSP: Esta clase es subtipo de IAcumulable por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones.

// Polimorfismo: Value es una propiedad polimorfica a todos los IAcumulables.

namespace Library
{
    public class Coins : IAcumulable
    {
        public int Value {get; private set; }

        public Coins(int value)
        {
            this.Value = value;
        }
    }
}