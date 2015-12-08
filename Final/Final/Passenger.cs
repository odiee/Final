using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Passenger
    {
        private string Name;
        private double Weight;
        public static double Totalweight = 0;


        public Passenger(string Name, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
            Totalweight += Weight;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }
     }}
