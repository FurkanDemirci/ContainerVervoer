using System;
using System.Collections.Generic;

namespace ContainerVervoer.Models
{
    /// <summary>
    /// The whole ship itself.
    /// </summary>
    public class Ship
    {
        public decimal RowBalance { get; set; }
        public double MaxWeight { get; }
        public double MinWeight { get; }
        public List<Place> Places { get; }

        public Ship(List<Place> places, double maxWeight)
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
        public void Balance()
        {
            for (int i = 0; i < 6; i = i + 2)
            {
                if (Places[i + 1].Containers.Count != 0)
                {
                    if (!((Places[i].Weight - Places[i + 1].Weight) / Places[i + 1].Weight * 100 > -20)) continue;
                    foreach (var container in Places[i].Containers)
                    {
                        if (container.Valuable) continue;
                        var placed = Places[i + 1].AddContainer(container);
                        if (!placed) continue;
                        var deleted = Places[i].DeleteContainer(container);
                        if (!deleted) continue;
                        break;
                    }
                }
                else
                {
                    foreach (var container in Places[i].Containers)
                    {
                        if (container.Valuable) continue;
                        var placed = Places[i + 1].AddContainer(container);
                        if (!placed) continue;
                        var deleted = Places[i].DeleteContainer(container);
                        if (!deleted) continue;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Calculates the balance between row 1 and row 2.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateBalance()
        {
            double row1 = 0;
            double row2 = 0;

            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 2 || i == 4)
                    row1 = row1 + Places[i].Weight; 
                else
                    row2 = row2 + Places[i].Weight;
            }
            RowBalance = Convert.ToDecimal((row2 - row1) / row1 * 100);
            return RowBalance;
        }
    }
}