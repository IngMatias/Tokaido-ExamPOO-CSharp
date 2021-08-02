
// SRP: Esta clase tiene la responsabilidad de conocer el camino recorrido por el usuario, tanto sus recpomenzas como las experiencias visitadas. 

// OCP: Basta con heredar esta clase para agregar jugadores diferentes.

// DIP: Esta clase de alto nivel depende de clases de alto nivel y bajo nivel (HeadAcumulableToInt).

// Expert: Esta clase conoce los lugares visitados, se encarga de contar las anteriores visitas de un cada experiencia.
// Esta clase conoce los beneficios obtenidos, se encarga de retornar el conteo final de los puntos.

// Creator: Esta clase usa de forma cercana HeadAcumulableToInt, se encarga de su creacion.

using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractTraveler
    {
        private string _name;
        private List<IExperience> _visited;
        private List<IAcumulable> _acumulated;
        public AbstractTraveler(string name)
        {
            this._name = name;
            this._visited = new List<IExperience> ();
            this._acumulated = new List<IAcumulable> ();
        }
        public void Add(IExperience visited, IAcumulable benefict)
        {
            this._visited.Add(visited);
            this._acumulated.Add(benefict);
        }
        public int Visits(IExperience newVisit)
        {
            int count = 0;
            foreach (IExperience visited in this._visited)
            {
                if (newVisit.GetType().Equals(visited.GetType()))
                {
                    count ++;
                }
            }
            return count;
        }
        public (string, int) Result()
        {
            AbstractIAcumulableToInt convertor = new HeadAcumulableToInt();
            int result = 0;
            foreach (IAcumulable benefict in this._acumulated)
            {
                result += convertor.Convert(benefict);
            }
            return (this._name, result);
        }
    }
}