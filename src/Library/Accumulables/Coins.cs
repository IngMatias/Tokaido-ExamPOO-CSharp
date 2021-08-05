
// SRP: Esta clase tiene la responsabilidad de contener un valor de un tipo de moneda.

// OCP: Esta clase es un ejemplo del agregado de una moneda implementando la interface IAcumulable.

// LSP: Esta clase es subtipo de IAcumulable por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones.

// Polimorfismo: Value es una propiedad polimorfica a todos los IAcumulables.

namespace Library
{
    /// <summary>
    /// Esta clase representa una bolsa de monedas de tipo <c>Coins</c>
    /// </summary>
    public class Coins : IAcumulable
    {
        public int Value {get; private set; }

        /// <summary>
        /// Inicializa una instancia de <c>Coins</c>.
        /// </summary>
        /// <param name="value">La cantidad de monedas dentro de la bolsa (no es posible alterar su valor una vez instanciado).</param>
        public Coins(int value)
        {
            this.Value = value;
        }
    }
}