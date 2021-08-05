
// SRP: Esta clase tiene la responsabilidad de definir el ultimo eslabon de la cadena de conversion IAcumulable To int.

// OCP: Esta clase es un ejemplo del agregado de un eslabon a la cadena heredando la clase AbstractIAcumulableToInt.

// LSP: Esta clase es subtipo de AbstractIAcumulableToInt por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende solamente de clases de alto nivel.

// Creator: Esta clase larga una excepcion, la usa de forma cercana, por lo que se encarga de crearla.

using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa el ultimo eslabon en la cadena de conversiones.
    /// </summary>
    public class NullAcumulableToInt : AbstractIAcumulableToInt
    {
        /// <summary>
        /// Inicializa una instancia de <c>NullAcumulableToInt</c>
        /// </summary>
        public NullAcumulableToInt()
        :base(null)
        {
        }
        public override int Convert(IAcumulable benefict)
        {
            // Cuando se llega al ultimo eslabon se lanza una excepcion de falta de implementacion de convertor.
            // Esto ayuda al agregado de nuevas monedas rapidamente.
            throw new NotImplementedException();
        }
    }
}