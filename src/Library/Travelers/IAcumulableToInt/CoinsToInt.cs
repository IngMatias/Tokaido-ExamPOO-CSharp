
// SRP: Esta clase tiene la responsabilidad de definir la conversion Coins a int.

// OCP: Esta clase es un ejemplo del agregado de una moneda heredando la clase AbstractIAcumulableToInt.

// LSP: Esta clase es subtipo de AbstractIAcumulableToInt por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de clases de alto nivel y bajo nivel (PointsToInt y Coins).

// Expert: Esta clase conoce el valor de un Point, se encarga de convertirlos a int.

// Creator: Como esta clase usa de forma cercana PointsToInt, se encarga de crearlo.

namespace Library
{
    /// <summary>
    /// Esta clase retorna el valor de una bolsa de <c>Coins</c>.
    /// </summary>
    public class CoinsToInt : AbstractIAcumulableToInt
    {
        /// <summary>
        /// Valor de un coin.
        /// </summary>
        private int _onePointValue;

        /// <summary>
        /// Inicializa una instancia de <c>CoinsToInt</c>.
        /// </summary>
        public CoinsToInt()
        :base(new PointsToInt())
        {
            this._onePointValue = 1;
        }
        public override int Convert(IAcumulable benefict)
        {
            if (benefict is Coins)
            {
                return benefict.Value * this._onePointValue;
            }
            else
            {
                return this.SendNext(benefict);
            }
        }
    }
}