namespace ContainerVervoer.Models
{
    /// <summary>
    /// Container with it's properties. 
    /// </summary>
    public class Container
    {
        public bool Valuable { get; }
        public bool Cooled { get; }
        public int Weight { get; }

        public Container(bool valuable, bool cooled, int weight)
        {
            Valuable = valuable;
            Cooled = cooled;
            Weight = weight;
        }
    }
}
