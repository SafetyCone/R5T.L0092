using System;


namespace R5T.L0092
{
    public class NullOperator : INullOperator
    {
        #region Infrastructure

        public static INullOperator Instance { get; } = new NullOperator();


        private NullOperator()
        {
        }

        #endregion
    }
}
