using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is a resolved path (does not contain any current or parent directory path parts).
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsUnresolvedPath"/>.
    /// </remarks>
    [CheckMarker]
    public interface IIsResolvedPath : ICheckMarker
    {
    }
}
