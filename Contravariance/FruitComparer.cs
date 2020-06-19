namespace Contravariance
{
    class FruitComparer : IMyComparer<Fruit>
    {
        public int Compare(Fruit l, Fruit r)
        {
            return (int)(l.Weight - r.Weight);
        }
    }
}
