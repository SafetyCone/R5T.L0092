using System;
using System.Collections.Generic;
using System.Linq;
using R5T.L0091.T000;
using R5T.L0092.T001;


namespace R5T.L0092
{
    public partial interface IPathOperator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note the output is not checked for:
        /// <list type="bullet">
        /// <item><see cref="INotEmpty"/></item>
        /// <item><see cref="IIsRootedPath"/></item>
        /// <item><see cref="IIsWindowsPath"/></item>
        /// <item><see cref="IIsNonWindowsPath"/></item>
        /// </list>
        /// </remarks>
        public string Combine_ToDirectoryPath(
            out (IChecked<IIsDirectoryIndicated>, IChecked<IIsResolvedPath>, IChecked<IUsesStandardDirectorySeparator>, IChecked<INoWhitespacePathParts>, IChecked<INotNull>) outputChecked,
            params string[] pathParts)
        {
            var combinedPath = this.Combine(
                out var combinedPathchecked,
                pathParts);

            var output = this.Ensure_IsDirectoryIndicated(
                combinedPath,
                out var isDirectoryIndicatedChecked);

            outputChecked = Instances.TupleOperator.Combine(
                isDirectoryIndicatedChecked,
                combinedPathchecked);

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note the output is not checked for:
        /// <list type="bullet">
        /// <item><see cref="INotEmpty"/></item>
        /// <item><see cref="IIsRootedPath"/></item>
        /// <item><see cref="IIsWindowsPath"/></item>
        /// <item><see cref="IIsNonWindowsPath"/></item>
        /// </list>
        /// </remarks>
        public string Combine_ToFilePath(
            out (IChecked<IIsFileIndicated>, IChecked<IIsResolvedPath>, IChecked<IUsesStandardDirectorySeparator>, IChecked<INoWhitespacePathParts>, IChecked<INotNull>) outputChecked,
            params string[] pathParts)
        {
            var combinedPath = this.Combine(
                out var combinedPathchecked,
                pathParts);

            var output = this.Ensure_IsFileIndicated(
                combinedPath,
                out var isFileIndicatedChecked);

            outputChecked = Instances.TupleOperator.Combine(
                isFileIndicatedChecked,
                combinedPathchecked);

            return output;
        }

        /// <summary>
        /// 
        /// Returns <see cref="L0066.IPaths.EmptyPath"/> if path parts is null, empty, or only contains whitespace strings.
        /// </summary>
        /// <remarks>
        /// Note the output is not checked for:
        /// <list type="bullet">
        /// <item><see cref="INotEmpty"/></item>
        /// <item><see cref="IIsDirectoryIndicated"/></item>
        /// <item><see cref="IIsFileIndicated"/></item>
        /// <item><see cref="IIsRootedPath"/></item>
        /// <item><see cref="IIsWindowsPath"/></item>
        /// <item><see cref="IIsNonWindowsPath"/></item>
        /// </list>
        /// </remarks>
        public string Combine(
            out (IChecked<IIsResolvedPath>, IChecked<IUsesStandardDirectorySeparator>, IChecked<INoWhitespacePathParts>, IChecked<INotNull>) outputChecked,
            params string[] pathParts)
        {
            // Get this out of the way first to allow returning from special cases below.
            outputChecked = (
                Checked.Check<IIsResolvedPath>(),
                Checked.Check<IUsesStandardDirectorySeparator>(),
                Checked.Check<INoWhitespacePathParts>(),
                Checked.Check<INotNull>()
            );

            // Special cases.
            // Null or empty array.
            var isArrayNullOrEmpty = Instances.ArrayOperator.Is_NullOrEmpty(pathParts);
            if(isArrayNullOrEmpty)
            {
                return Instances.Paths.EmptyPath;
            }

            // Ensure path parts.
            var pathParts_NotNullEmptyOrWhitespace = pathParts
                .Where(Instances.StringOperator.Is_NotNullOrEmpty)
                .Where(Instances.StringOperator.Is_NotWhitespace)
                .Now();

            var isEmpty = Instances.ArrayOperator.Is_Empty(pathParts_NotNullEmptyOrWhitespace);
            if(isEmpty)
            {
                return Instances.Paths.EmptyPath;
            }

            var onlyOne = Instances.ArrayOperator.Is_LengthOfOne(pathParts_NotNullEmptyOrWhitespace);
            if(onlyOne)
            {
                var output_ForSinglePathPart = Instances.ArrayOperator.Get_First(pathParts_NotNullEmptyOrWhitespace);
                return output_ForSinglePathPart;
            }

            // Now we know we have multiple path parts.
            var directoryIndicatedPathParts = Instances.EnumerableOperator.Except_Last(pathParts_NotNullEmptyOrWhitespace)
                // Make not directory indicated so we can join using the desired directory separator below.
                .Select(this.Ensure_IsNotDirectoryIndicated)
                ;

            var outputFirstPathPart = directoryIndicatedPathParts.First();

            var relativePathParts = Instances.EnumerableOperator.Append(
                Instances.EnumerableOperator.Except_First(directoryIndicatedPathParts),
                Instances.ArrayOperator.Get_Last(pathParts_NotNullEmptyOrWhitespace))
                .Select(this.Ensure_IsRelative)
                ;

            var outputPathParts = Instances.EnumerableOperator.From(outputFirstPathPart)
                .Append(relativePathParts)
                ;

            var directorySeparator = Instances.DirectorySeparators.Standard;

            var output_Initial = Instances.StringOperator.Join(
                directorySeparator,
                outputPathParts);

            // Perform final ensures.
            var output_EnsuredStandardDirectorySeparator = this.Ensure_UsesDirectorySeparator(
                output_Initial,
                directorySeparator);

            var output = this.Resolve_Path(output_EnsuredStandardDirectorySeparator);
            return output;
        }

        /// <summary>
        /// Performs a simple string concatenation.
        /// </summary>
        public string Combine_PathParts(
            string pathPart1,
            string pathPart2,
            IChecked<IIsDirectoryIndicated> pathPart1Checked,
            IChecked<IIsRelativePath> pathPart2Checked)
        {
            var output = _Base.Combine_PathParts(
                pathPart1,
                pathPart2);

            return output;
        }
    }
}
