using System;


namespace R5T.L0092
{
    public class PathOperator : IPathOperator
    {
        #region Infrastructure

        public static IPathOperator Instance { get; } = new PathOperator();


        private PathOperator()
        {
        }

        #endregion
    }
}
