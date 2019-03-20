using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.parts;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызов без васада
            Door door = new Door();
            door.Open();

            Start start = new Start();
            start.fire();

            Wheel wheel = new Wheel();
            wheel.Turn();

            // вызов с фасадом
        }
    }
}
