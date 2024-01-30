using System;

using R5T.T0243;
using R5T.V0002;


namespace R5T.L0092.V000
{
    /// <summary>
    /// Pather operator test article for the functionality method instances in <see cref="IPathOperator"/>.
    /// </summary>
    [TestArticleImplementationMarker]
    public class PathOperatorTestArticle : ITestArticleImplementationMarker,
        IPathOperatorTestArticle
    {
        public string Combine_ToFilePath(string[] pathParts)
        {
            var output = Instances.PathOperator.Combine_ToFilePath(
                out _,
                pathParts);

            return output;
        }

        public bool Is_FileIndicated(string pathPart)
        {
            var output = Instances.PathOperator.Is_FileIndicated(pathPart);
            return output;
        }

        public bool Is_Windows(string pathPart)
        {
            var output = Instances.PathOperator.Is_Windows(pathPart);
            return output;
        }
    }
}
