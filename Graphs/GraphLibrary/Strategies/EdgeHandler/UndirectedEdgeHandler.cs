using System.Collections.Generic;
using System.Linq;
using GraphLibrary.Exceptions;
using GraphLibrary.Factories;
using GraphLibrary.GraphObjects;

namespace GraphLibrary.Strategies.EdgeHandler
{
	public class UndirectedEdgeHandler: IEdgeHandlerStrategy
	{
		private readonly EdgeFactory _edgeFactory;

		public UndirectedEdgeHandler(EdgeFactory edgeFactory)
		{
			_edgeFactory = edgeFactory;
		}

		public EdgeAbstract AddEdge(List<Vertex> vertexes, string vertexFromName, string vertexToName, int? weight)
		{
			if (vertexes.All(v => v.Name != vertexFromName))
			{
				throw new GraphException("Vertex from do not exist");
			}

			if (vertexes.All(v => v.Name != vertexToName))
			{
				throw new GraphException("Vertex to do not exist");
			}

			var vertexFrom = vertexes.First(v => v.Name == vertexFromName);
			var vertexTo = vertexes.First(v => v.Name == vertexToName);

			EdgeAbstract edge = _edgeFactory.GetEdge(vertexes, vertexFromName, vertexToName, weight);
			EdgeAbstract edge2 = _edgeFactory.GetEdge(vertexes, vertexToName, vertexFromName, weight);

			vertexFrom.Edges.Add(edge);
			vertexTo.Edges.Add(edge2);

			return edge;
		}

		public EdgeAbstract RemoveEdge(List<Vertex> vertexes, string vertexFromName, string vertexToName)
		{
			throw new System.NotImplementedException();
		}
	}
}