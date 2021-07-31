
// SRP: Esta clase tiene la responsabilidad de definir el primer eslabon de la cadena de conversion IAcumulable To int.

// OCP: Esta clase es un ejemplo del agregado de un eslabon a la cadena heredando la clase AbstractIAcumulableToInt.

// LSP: Esta clase es subtipo de AbstractIAcumulableToInt por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de clases de alto nivel y bajo nivel (CoinsToInt).

// Creator: Como esta clase usa de forma cercana CoinsToInt, se encarga de crearlo.

namespace Library
{
    public class HeadAcumulableToInt : AbstractIAcumulableToInt
    {
        public HeadAcumulableToInt()
        :base(new CoinsToInt())
        {

        }
        public override int Convert(IAcumulable benefict)
        {
            return this.SendNext(benefict);
        }
    }
}