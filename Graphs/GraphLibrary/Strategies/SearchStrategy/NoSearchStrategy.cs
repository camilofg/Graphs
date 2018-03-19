using System.Collections.Generic;
using GraphLibrary.Exceptions;
using GraphLibrary.GraphObjects;

namespace GraphLibrary.Strategies.SearchStrategy
{
	public class NoSearchStrategy : ISearchStrategy
	{
		public Vertex Search(List<Vertex> vertexes, string vertexFrom, string vertexToSearch)
		{
			throw new GraphException("Search is not incluyed in this package.");
		}
	}
}