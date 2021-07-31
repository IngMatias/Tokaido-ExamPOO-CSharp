
// SRP: Esta clase tiene la responsabilidad de definir un eslabon de la cadena de conversion IAcumulable To int.

// OCP: Basta con heredar esta clase para agregar un nuevo tipo de moneda.

// DIP: Esta clase de alto nivel depende solo de clases de alto nivel.

// Expert: Esta clase conoce el siguiente eslabon, se encarga de enviar el IAcumulable al siguiente.

namespace Library
{
    public abstract class AbstractIAcumulableToInt
    {
        private AbstractIAcumulableToInt _next;
        public AbstractIAcumulableToInt(AbstractIAcumulableToInt next)
        {
            this._next = next;
        }
        public abstract int Convert(IAcumulable benefict);
        protected int SendNext(IAcumulable benefict)
        {
            return this._next.Convert(benefict);
        }
    }
}