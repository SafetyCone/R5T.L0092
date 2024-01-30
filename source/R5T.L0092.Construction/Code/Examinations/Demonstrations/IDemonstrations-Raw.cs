using System;

using R5T.T0141;


namespace R5T.L0092.Construction.Raw
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// Given a set of path parts, combines path parts into a directory path.
        /// </summary>
        public void N001()
        {
            /// Inputs.
            var pathParts =
                Instances.PathPartSets._Raw.N001
                ;


            /// Run.
            var path = Instances.PathOperator.Combine_ToDirectoryPath(
                out _,
                pathParts);

            Console.WriteLine(path);
        }
    }
}
