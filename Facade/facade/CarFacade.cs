using System.Xml.Serialization;
using Facade.parts;

namespace Facade.facade
{
    public class CarFacade
    {
        // Можно реализовывать итерфейс, для большего подхода ООП
        private Door _door = new Door();
        private Start _start = new Start();
        private Wheel _wheel = new Wheel();

        public void Go()
        {
            _door.Open();
            _start.fire();
            _wheel.Turn();
        }
    }
}