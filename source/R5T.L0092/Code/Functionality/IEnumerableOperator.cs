using System;
using System.Collections.Generic;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.T0132;


namespace R5T.L0092
{
    [FunctionalityMarker]
    public partial interface IEnumerableOperator : IFunctionalityMarker,
        L0066.IEnumerableOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IEnumerableOperator _Base => L0066.EnumerableOperator.Instance;
        private Implementations.IEnumerableOperator _Implementations => Implementations.EnumerableOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public T Get_First<T>(
            IEnumerable<T> values,
            IChecked<INotNull> checkedValuesNotNull)
        {
            var output = _Implementations.Get_First_UsingEnumerator(
                values,
                checkedValuesNotNull);

            return output;
        }
    }
}
