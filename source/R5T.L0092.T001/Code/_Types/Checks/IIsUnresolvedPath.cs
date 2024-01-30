using System;

using R5T.T0142;
using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is an unresolved path (contain a current or parent directory path part).
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsResolvedPath"/>.
    /// </remarks>
    [CheckMarker, DataTypeMarker]
    public interface IIsUnresolvedPath : ICheck
    {
    }
}
