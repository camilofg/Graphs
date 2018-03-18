using System;

namespace GraphLibrary.Exceptions
{
	public class GraphException : Exception
	{
		public GraphException(string message) : base(message)
		{
		}
	}
}