namespace Contravariance
{
    delegate int SortingDelegate<in T>(T l, T r);
}
