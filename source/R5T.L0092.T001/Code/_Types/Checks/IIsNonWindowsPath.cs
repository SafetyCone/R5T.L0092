using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is non-Windows path (uses the non-Windows directory separator '/').
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsWindowsPath"/>.
    /// </remarks>
    [CheckMarker]
    public interface IIsNonWindowsPath : ICheckMarker
    {
    }
}
