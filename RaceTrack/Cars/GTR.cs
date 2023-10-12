using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    internal class GTR : RaceCar
    {
        public GTR() {
            Name = "GTR";
            TopSpeed = 195;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine Roars up");
        }

        public override void Brake()
        {
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine turns off");
        }
    }
}
