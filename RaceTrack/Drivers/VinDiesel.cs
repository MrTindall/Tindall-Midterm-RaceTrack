using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    internal class VinDiesel : Driver
    {
        public VinDiesel(RaceCar car) : base(car)
        {
            Name = "Vin Diesel";
            SkillLevel = 10;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
