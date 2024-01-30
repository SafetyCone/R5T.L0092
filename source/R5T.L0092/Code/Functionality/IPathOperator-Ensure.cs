using System;

using R5T.L0091.T000;
using R5T.L0092.T001;


namespace R5T.L0092
{
    public partial interface IPathOperator
    {
        public string Ensure_IsDirectoryIndicated(
            string pathPart,
            out IChecked<IIsDirectoryIndicated> outputChecked)
        {
            var output = this._Checked.Ensure_IsDirectoryIndicated_CheckNotNullOrEmpty(pathPart);

            outputChecked = Checked.Check<IIsDirectoryIndicated>();

            return output;
        }

        public string Ensure_IsDirectoryIndicated(
            string pathPart,
            IChecked<INotNullOrEmpty> pathPartChecked,
            out IChecked<IIsDirectoryIndicated> outputChecked)
        {
            var output = this.Ensure_IsDirectoryIndicated(pathPart);

            outputChecked = Checked.Check<IIsDirectoryIndicated>();

            return output;
        }

        public string Ensure_IsFileIndicated(
            string pathPart,
            out IChecked<IIsFileIndicated> @checked)
        {
            var output = this.Ensure_IsFileIndicated(pathPart);

            @checked = Checked.Check<IIsFileIndicated>();

            return output;
        }

        public string Ensure_IsRelative(
            string pathPart,
            out IChecked<IIsRelativePath> @checked)
        {
            var output = this.Ensure_IsRelative(pathPart);

            @checked = Checked.Check<IIsRelativePath>();

            return output;
        }
    }
}
