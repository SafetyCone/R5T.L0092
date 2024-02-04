using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a file exists.
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IFileDoesNotExist"/>.
    /// </remarks>
    [CheckMarker]
    public interface IFileExists : ICheckMarker
    {
    }
}
