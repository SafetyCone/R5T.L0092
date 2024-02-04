using System;

using R5T.T0244;



namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a collection is not null or empty.
    /// </summary>
    [CheckMarker]
    public interface INotNullOrEmpty : ICheckMarker,
        INotEmpty,
        INotNull
    {
    }
}
