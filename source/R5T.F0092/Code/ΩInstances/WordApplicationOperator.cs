using System;


namespace R5T.F0092
{
	public class WordApplicationOperator : IWordApplicationOperator
	{
		#region Infrastructure

	    public static IWordApplicationOperator Instance { get; } = new WordApplicationOperator();

	    private WordApplicationOperator()
	    {
        }

	    #endregion
	}
}