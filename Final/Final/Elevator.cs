using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Elevator
    {

        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(double maxWeight, int MaxOccupants)

        {
            MaxWeight = maxWeight;
            Occupants = new Passenger[MaxOccupants];

        }

        public void AddOccupant(Passenger passenger, int index)
        {

            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            return Passenger.Totalweight;
        }

        public bool IsOverMaxCapacity()
        {

            if (GetCurrentWeight() >= MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    

