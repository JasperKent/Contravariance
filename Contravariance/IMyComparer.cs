namespace Contravariance
{
    interface IMyComparer<in T>
    {
        int Compare(T l, T r);
    }
}
