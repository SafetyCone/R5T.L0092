using System;
using System.Collections.Generic;

using R5T.L0091.T000;
using R5T.T0132;

using R5T.L0092.T001;


namespace R5T.L0092.Implementations
{
    [FunctionalityMarker]
    public partial interface IEnumerableOperator : IFunctionalityMarker,
        L0066.IEnumerableOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.Implementations.IEnumerableOperator _Base => L0066.Implementations.EnumerableOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public T Get_First_UsingEnumerator<T>(
            IEnumerable<T> values,
            IChecked<INotNull> checkedValuesNotNull)
        {
            var output = _Base.Get_First_UsingEnumerator(values);
            return output;
        }

        public T Get_First_UsingLinq<T>(
            IEnumerable<T> values,
            IChecked<INotNull> checkedValuesNotNull)
        {
            var output = _Base.Get_First_UsingLinq(values);
            return output;
        }
    }
}
