
// SRP: Esta clase tiene la responsabilidad de definir la conversion Points a int.

// OCP: Esta clase es un ejemplo del agregado de una moneda heredando la clase AbstractIAcumulableToInt.

// LSP: Esta clase es subtipo de AbstractIAcumulableToInt por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de clases de alto nivel y bajo nivel (NullAcumulableToInt y Points).

// Expert: Esta clase conoce el valor de un Coin, se encarga de convertirlos a int.

// Creator: Como esta clase usa de forma cercana NullAcumulableToInt, se encarga de crearlo.

namespace Library
{
    public class PointsToInt : AbstractIAcumulableToInt
    {
        private int _onePointValue;
        public PointsToInt()
        :base(new NullAcumulableToInt())
        {
            this._onePointValue = 3;
        }
        public override int Convert(IAcumulable benefict)
        {
            if (benefict is Points)
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