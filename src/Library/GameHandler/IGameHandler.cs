
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de manejador de partida.

// ISP: Esta interface define varias operaciones, que el cliente debe usar para no depender de tipos que no se usan.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

using System.Collections.ObjectModel;

namespace Library
{
    public interface IGameHandler
    {
        public void StartGame();
        public bool IsStarted();
        public void Add(IExperience experience);
        public void Remove(IExperience experience);
        public void Add(AbstractTraveler traveler);
        public void Remove(AbstractTraveler traveler);
        public void Move(AbstractTraveler traveler, IExperience to);
        public bool IsEnded();
        public ReadOnlyCollection<(string, int)> Result();
    }
}