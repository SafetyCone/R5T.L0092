﻿using System;

using R5T.T0142;
using R5T.T0244;



namespace R5T.L0092.T001
{
    /// <summary>
    /// Check that a collection is not null or empty.
    /// </summary>
    [CheckMarker, DataTypeMarker]
    public interface INotNullOrEmpty : ICheck,
        INotEmpty,
        INotNull
    {
    }
}
