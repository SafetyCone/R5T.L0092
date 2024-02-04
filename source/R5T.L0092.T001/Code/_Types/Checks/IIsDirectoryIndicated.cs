using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is directory indicated (ends with a directory separator).
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsFileIndicated"/>.
    /// </remarks>
    [CheckMarker]
    public interface IIsDirectoryIndicated : ICheckMarker
    {
    }
}
