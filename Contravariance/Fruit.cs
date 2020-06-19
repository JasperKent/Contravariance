namespace Contravariance
{
    class Fruit
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Weight}g)";
        }
    }
}
