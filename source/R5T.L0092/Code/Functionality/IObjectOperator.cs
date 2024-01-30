using System;

using R5T.L0091.T000;
using R5T.T0132;

using R5T.L0092.T001;


namespace R5T.L0092
{
    [FunctionalityMarker]
    public partial interface IObjectOperator : IFunctionalityMarker,
        L0066.IObjectOperator
    {
        public string To_String(
            object @object,
            IChecked<INotNull> checkedObjectNotNull)
        {
            var output = @object.ToString();
            return output;
        }

        public string To_String(
            object @object,
            out IChecked<INotNull> checkedObjectNotNull)
        {
            Instances.NullOperator.Verify_IsNotNull(
                @object,
                out checkedObjectNotNull);

            var output = this.To_String(
                @object,
                checkedObjectNotNull);

            return output;
        }
    }
}
