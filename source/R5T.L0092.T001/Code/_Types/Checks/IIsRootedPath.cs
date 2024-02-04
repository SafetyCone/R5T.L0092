using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is a rooted path (begins with a directory separator or drive identifier).
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsRelativePath"/>.
    /// </remarks>
    [CheckMarker]
    public interface IIsRootedPath : ICheckMarker
    {
    }
}
