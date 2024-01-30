using System;

using R5T.L0091.T000;
using R5T.T0132;

using R5T.L0092.T001;


namespace R5T.L0092
{
    [FunctionalityMarker]
    public partial interface INullOperator : IFunctionalityMarker,
        L0066.INullOperator
    {
        public void Verify_IsNotNull<T>(
            T value,
            out IChecked<INotNull> checkedValueNotNull)
            where T : class
        {
            var isNull = this.Is_NotNull(value);
            if(isNull)
            {
                throw new NullReferenceException("Value was null.");
            }

            checkedValueNotNull = Checked.Check<INotNull>();
        }
    }
}
