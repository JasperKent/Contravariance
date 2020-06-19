namespace Contravariance
{
    interface IContravariant<in T>
    {

    }

    class Contravariant<T> : IContravariant<T>
    { 
    }
}
