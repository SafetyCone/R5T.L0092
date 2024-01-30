using System;

using R5T.L0091.T000;
using R5T.T0132;

using R5T.L0092.T001;


namespace R5T.L0092
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker,
        L0066.IStringOperator
    {
        public char Get_FirstCharacter(
            string @string,
            IChecked<INotNullOrEmpty> checkedStringNotNull)
        {
            var output = Instances.EnumerableOperator.Get_First(@string);
            return output;
        }

        public char Get_FirstCharacter(
            string @string,
            out IChecked<INotNullOrEmpty> checkedStringNotNull)
        {
            this.Verify_NotNullOrEmpty(
                @string,
                out checkedStringNotNull);

            var output = this.Get_FirstCharacter(
                @string,
                checkedStringNotNull);

            return output;
        }

        public bool Verify_NotNullOrEmpty(
            string @string,
            out IChecked<INotNullOrEmpty> checkedStringNotNull)
        {
            var isNullOrEmpty = this.Is_NullOrEmpty(@string);
            if (isNullOrEmpty)
            {
                throw new Exception($"String was null or empty.");
            }

            checkedStringNotNull = Checked.Check<INotNullOrEmpty>();

            var output = !isNullOrEmpty;
            return output;
        }
    }
}
