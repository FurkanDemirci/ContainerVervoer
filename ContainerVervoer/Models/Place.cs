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
        public double Weight { get; private set; }
        public int Position { get; }

        public Place(int position)
        {
            Position = position;
        }

        /// <summary>
        /// Add the container to the list while checking weight.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddContainer(Container model)
        {
            if (model.Valuable && Containers.Find(x => (x.Valuable)) != null) return false;
            if (!CheckWeight(model.Weight)) return false;
            Containers.Add(model);
            return true;
        }

        /// <summary>
        /// Deleting container and substracting weight.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteContainer(Container model)
        {
            var deleted = Containers.Remove(model);
            if (!deleted) return false;
            Weight = Weight - model.Weight;
            return true;
        }

        /// <summary>
        /// Checking weight of place.
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        private bool CheckWeight(double weight)
        {
            if (!(Weight + weight <= 150000)) return false;
            Weight = Weight + weight;
            return true;
        }

        /// <summary>
        /// SetPosition make's sure that valuable containers get placed on top.
        /// </summary>
        public void SetPosition()
        {
            if (Containers.Find(x => (x.Valuable)) != null)
            {
                var valuable = Containers[0];
                Containers.RemoveAt(0);
                Containers.Add(valuable);
            };
        }
    }
}