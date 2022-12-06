using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.F0092
{
    /// <summary>
    /// Functionality for the Word application as an executable.
    /// Does not have functionality for working with Word documents.
    /// </summary>
	[FunctionalityMarker]
	public partial interface IWordApplicationOperator : IFunctionalityMarker
	{
        public void Open()
        {
            Instances.CommandLineOperator.Run_Synchronous_NoWait(
                ExecutableFilePaths.Instance.Word);
        }

        public void Open(string filePath)
        {
            var enquotedFilePath = Instances.StringOperator.EnsureEnquoted(filePath);

            Instances.CommandLineOperator.Run_Synchronous_NoWait(
                ExecutableFilePaths.Instance.Word,
                enquotedFilePath);
        }

        public void Open(IEnumerable<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                this.Open(filePath);
            }
        }

        public void Open(params string[] filePaths)
        {
            this.Open(filePaths.AsEnumerable());
        }
    }
}