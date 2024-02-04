using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a file does not exist.
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IFileExists"/>.
    /// </remarks>
    [CheckMarker]
    public interface IFileDoesNotExist : ICheckMarker
    {
    }
}
