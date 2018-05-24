using System;
using System.Collections.Generic;

namespace ContainerVervoer.Models
{
    /// <summary>
    /// Place of a ship.
    /// </summary>
    public class Place
    {
        public List<Container> Containers { get; } = new List<Container>();
        public int Weight { get; }

        public Place(int weight)
        {
            Weight = weight;
        }

        /// <summary>
        /// Add container to place.
        /// </summary>
        /// <returns>Boolean</returns>
        public bool Add(Container model)
        {
            // Controleer gewicht en return bool.
            throw new NotImplementedException();
        }
    }
}