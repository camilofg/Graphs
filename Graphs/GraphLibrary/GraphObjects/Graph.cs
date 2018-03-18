using System.Collections.Generic;
using System.Linq;
using GraphLibrary.Exceptions;
using GraphLibrary.Strategies.EdgeHandler;
using GraphLibrary.Strategies.SearchStrategy;

namespace GraphLibrary.GraphObjects
{
	public class Graph
	{
		private readonly IEdgeHandlerStrategy _edgeHandlerStrategy;

		private readonly ISearchStrategy _searchStrategy;

		public Graph(IEdgeHandlerStrategy edgeHandlerStrategy, ISearchStrategy searchStrategy)
		{
			_edgeHandlerStrategy = edgeHandlerStrategy;
			_searchStrategy = searchStrategy;

			Vertexes = new List<Vertex>();
		}

		private List<Vertex> Vertexes { get; }

		public EdgeAbstract AddEdge(string vertexFromName, string vertexToName, int? weight = null)
		{
			return _edgeHandlerStrategy.AddEdge(Vertexes, vertexFromName, vertexToName, weight);
		}

		public Vertex AddVertex(string vertexName)
		{
			if (Vertexes.Any(v => v.Name == vertexName))
			{
				throw new GraphException("The vertex aready exits");
			}

			var vertex = new Vertex
			{
				Name = vertexName
			};

			Vertexes.Add(vertex);

			return vertex;
		}

		public string[,] GetGraphView()
		{
			var matrix = new string[Vertexes.Count + 1, Vertexes.Count + 1];

			for (var i = 0; i < Vertexes.Count; i++)
			{
				matrix[i + 1, 0] = Vertexes[i].Name;
				matrix[0, i + 1] = Vertexes[i].Name;

				for (var j = 0; j < Vertexes.Count; j++)
				{
					if (Vertexes[i].HasPath(Vertexes[j].Name))
					{
						matrix[i + 1, j + 1] = Vertexes[i].GetWeight(Vertexes[j].Name);
					}
				}
			}

			return matrix;
		}

		public EdgeAbstract RemoveEdge(string vertexFromName, string vertexToName)
		{
			return _edgeHandlerStrategy.RemoveEdge(Vertexes, vertexFromName, vertexToName);
		}

		public Vertex RemoveVertex(string vertexName)
		{
			if (Vertexes.All(v => v.Name != vertexName))
			{
				throw new GraphException("The vertex do not exits");
			}

			var vertexToRemove = Vertexes.First(v => v.Name == vertexName);

			foreach (var vertex in Vertexes)
			{
				vertex.RemoveEdgeTo(vertex.Name);
			}

			Vertexes.Remove(vertexToRemove);

			return vertexToRemove;
		}

		public Vertex Search(string vertexFrom, string vertexToSearch)
		{
			return _searchStrategy.Search(vertexFrom, vertexToSearch);
		}
	}
}