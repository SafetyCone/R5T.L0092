using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path is a Windows path (uses the Windows directory separator '\').
    /// </summary>
    /// <remarks>
    /// For the opposite, see <see cref="IIsNonWindowsPath"/>.
    /// </remarks>
    [CheckMarker]
    public interface IIsWindowsPath : ICheckMarker
    {
    }
}
