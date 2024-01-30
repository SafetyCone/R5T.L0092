using System;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.T0132;


namespace R5T.L0092
{
    [FunctionalityMarker]
    public partial interface IPathOperator : IFunctionalityMarker,
        L0066.IPathOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IPathOperator _Base => L0066.PathOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        

        public string Get_FilePath_ForFileName(
            string parentDirectoryPath,
            string fileName,
            IChecked<IIsDirectoryIndicated> parentDirectoryPathChecked,
            IChecked<IIsRelativePath> fileNameChecked)
        {
            // Because the parent directory path has been checked to be directory-indicated (ends with a directory separator),
            // and the file name has been checked to be a relative path (does not begin with a directory separator),
            // then a simple concatenation can be done.
            var output = this.Combine_PathParts(
                parentDirectoryPath,
                fileName,
                parentDirectoryPathChecked,
                fileNameChecked);

            return output;
        }

        public string Get_FilePath_ForFileName(
            string parentDirectoryPath,
            string fileName,
            out IChecked<IIsDirectoryIndicated> parentDirectoryPathChecked,
            out IChecked<IIsRelativePath> fileNameChecked)
        {
            var ensuredParentDirectoryPath = this.Ensure_IsDirectoryIndicated(
                parentDirectoryPath,
                out parentDirectoryPathChecked);

            var ensuredFileName = this.Ensure_IsRelative(
                fileName,
                out fileNameChecked);

            var output = this.Get_FilePath_ForFileName(
                ensuredParentDirectoryPath,
                ensuredFileName,
                parentDirectoryPathChecked,
                fileNameChecked);

            return output;
        }

        public void Verify_IsDirectoryIndicated(
            string pathPart,
            out IChecked<IIsDirectoryIndicated> @checked)
        {
            this.Verify_IsDirectoryIndicated(pathPart);

            @checked = Checked.Check<IIsDirectoryIndicated>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Ouputs a <see cref="IIsFileIndicated"/> check, because not directory-indicated means it is file-indicated.
        /// </remarks>
        public void Verify_NotDirectoryIndicated(
            string pathPart,
            out IChecked<IIsFileIndicated> @checked)
        {
            this.Verify_NotDirectoryIndicated(pathPart);

            @checked = Checked.Check<IIsFileIndicated>();
        }

        public void Verify_IsFileIndicated(
            string pathPart,
            out IChecked<IIsFileIndicated> @checked)
        {
            this.Verify_IsFileIndicated(pathPart);

            @checked = Checked.Check<IIsFileIndicated>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Ouputs a <see cref="IIsDirectoryIndicated"/> check, because not file-indicated means it is directory-indicated.
        /// </remarks>
        public void Verify_NotFileIndicated(
            string pathPart,
            out IChecked<IIsDirectoryIndicated> @checked)
        {
            this.Verify_NotFileIndicated(pathPart);

            @checked = Checked.Check<IIsDirectoryIndicated>();
        }

        public void Verify_Is_WindowsPath(
            string pathPart,
            out IChecked<IIsWindowsPath> @checked)
        {
            var output = _Base.Is_Windows(pathPart);

            @checked = Checked.Check<IIsWindowsPath>();
        }
    }
}
