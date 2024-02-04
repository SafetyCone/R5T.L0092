using System;

using R5T.T0244;


namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a path uses the standard directory separator (the Windows directory separator '\' is the standard).
    /// </summary>
    /// <remarks>
    /// See related checks <see cref="IIsNonWindowsPath"/> and <see cref="IIsNonWindowsPath"/>.
    /// </remarks>
    [CheckMarker]
    public interface IUsesStandardDirectorySeparator : ICheckMarker
    {
    }
}
