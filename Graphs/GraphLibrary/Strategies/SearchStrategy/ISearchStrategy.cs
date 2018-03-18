using GraphLibrary.GraphObjects;

namespace GraphLibrary.Strategies.SearchStrategy
{
	public interface ISearchStrategy
	{
		Vertex Search(string vertexFrom, string vertexToSearch);
	}
}