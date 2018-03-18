using GraphLibrary.Factories;
using GraphLibrary.GraphObjects;

namespace GraphLibrary
{
	public static class GraphBuilder
	{
		public static Graph GetGraph(Options options)
		{
			var edgeHandlerFactory = new EdgeHandlerFactory(options);
			var searchFactory = new SearchFactory(options);

			return new Graph(edgeHandlerFactory.GetEdgeHandlerStrategy(), searchFactory.GetSearchStrategy());
		}
	}
}