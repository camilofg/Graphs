using System.Collections.Generic;
using GraphLibrary.GraphObjects;

namespace GraphLibrary.Strategies.SearchStrategy
{
	public interface ISearchStrategy
	{
		Vertex Search(List<Vertex> vertexes, string vertexFrom, string vertexToSearch);
	}
}