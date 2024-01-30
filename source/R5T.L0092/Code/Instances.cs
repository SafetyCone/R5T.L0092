using System;


namespace R5T.L0092
{
    public static class Instances
    {
        public static L0066.IArrayOperator ArrayOperator => L0066.ArrayOperator.Instance;
        public static L0066.IDirectorySeparators DirectorySeparators => L0066.DirectorySeparators.Instance;
        public static L0066.IEnumerableOperator EnumerableOperator => L0066.EnumerableOperator.Instance;
        public static INullOperator NullOperator => L0092.NullOperator.Instance;
        public static L0066.IPaths Paths => L0066.Paths.Instance;
        public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
        public static L0066.ITupleOperator TupleOperator => L0066.TupleOperator.Instance;
    }
}