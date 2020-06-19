namespace Contravariance
{
    interface ICovariant<out T>
    {

    }

    class Covariant<T> : ICovariant<T>
    {

    }
}
