using System;
using System.Collections.Generic;

namespace ContainerVervoer.Models
{
    /// <summary>
    /// The whole ship itself.
    /// </summary>
    public class Ship
    {
        public double Weight { get; }
        public int MaxWeight { get; }
        public double MinWeight { get; }
        public List<Place> Places { get; }

        public Ship(List<Place> places, int maxWeight)
        {
            Places = places;
            MaxWeight = maxWeight;
            MinWeight = CalculateMinWeight();
        }

        /// <summary>
        /// Calculates min weight of ship.
        /// </summary>
        /// <returns></returns>
        private double CalculateMinWeight()
        {
            return Convert.ToDouble(MaxWeight / 2);
        }

        /// <summary>
        /// Balances the ship to prevent capsize.
        /// </summary>
        /// <returns>Boolean</returns>
        public bool Balance()
        {
            throw new NotImplementedException();
        }
    }
}