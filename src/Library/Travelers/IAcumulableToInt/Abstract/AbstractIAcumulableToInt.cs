
// SRP: Esta clase tiene la responsabilidad de definir un eslabon de la cadena de conversion IAcumulable To int.

// OCP: Basta con heredar esta clase para agregar un nuevo tipo de moneda.

// DIP: Esta clase de alto nivel depende solo de clases de alto nivel.

// Expert: Esta clase conoce el siguiente eslabon, se encarga de enviar el IAcumulable al siguiente.

namespace Library
{
    /// <summary>
    /// Esta clase representa un eslabon de conversion de una moneda.
    /// </summary>
    public abstract class AbstractIAcumulableToInt
    {
        private AbstractIAcumulableToInt _next;
        /// <summary>
        /// Inicializa una instancia de AbstractIAcumulableToInt.
        /// </summary>
        /// <param name="next">Siguiente eslabon en tratar la conversion de la moneda.</param>
        public AbstractIAcumulableToInt(AbstractIAcumulableToInt next)
        {
            this._next = next;
        }
        /// <summary>
        /// Convierte una bolsa de monedas en su valor.
        /// </summary>
        /// <param name="benefict">Bolsa de monedas a calcular su valor.</param>
        /// <returns></returns>
        public abstract int Convert(IAcumulable benefict);
        /// <summary>
        /// Pasa la bolsa al siguiente eslabon para ser convertida a su valor.
        /// </summary>
        /// <param name="benefict">Bolsa de monedas a calcular su valor</param>
        /// <returns></returns>
        protected int SendNext(IAcumulable benefict)
        {
            return this._next.Convert(benefict);
        }
    }
}