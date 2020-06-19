using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Contravariance
{
    class ComparerAdapter<T> : IComparer<T>
    {
        private IMyComparer<T> _innerComparer;

        public ComparerAdapter(IMyComparer<T> innerComparer)
        {
            _innerComparer = innerComparer;
        }

        public int Compare([AllowNull] T x, [AllowNull] T y)
        {
            return _innerComparer.Compare(x, y);
        }
    }
}
