using System;

using R5T.T0141;


namespace R5T.L0092.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public static Raw.IDemonstrations _Raw => Raw.Demonstrations.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDemonstrations.N001"/>
        public void CombinePathParts_IntoDirectoryPath() => _Raw.N001();
    }
}
