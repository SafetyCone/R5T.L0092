using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is file indicated (does not end with a directory separator).
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsDirectoryIndicated"/>.
    /// </remarks>
    [CheckMarker]
    public interface IIsFileIndicated : ICheckMarker
    {
    }
}
