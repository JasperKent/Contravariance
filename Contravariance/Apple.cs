namespace Contravariance
{
    class Apple : Fruit
    {
        public bool ForEating { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} is for {(ForEating ? "eating" : "cooking")}";
        }
    }
}
