﻿using System.Collections.Generic;
using System.Linq;
using GraphLibrary.Exceptions;
using GraphLibrary.Factories;
using GraphLibrary.GraphObjects;

namespace GraphLibrary.Strategies.EdgeHandler
{
	public class DirectedEdgeHandler: IEdgeHandlerStrategy
	{
		private readonly EdgeFactory _edgeFactory;

		public DirectedEdgeHandler(EdgeFactory edgeFactory)
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

			var edge = _edgeFactory.GetEdge(vertexes, vertexFromName, vertexToName, weight);

			vertexFrom.Edges.Add(edge);

			return edge;
		}

		public void RemoveEdge(List<Vertex> vertexes, string vertexFromName, string vertexToName)
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

			vertexFrom.Edges.RemoveAll(e => e.VertexFrom.Name == vertexFromName && e.VertexTo.Name == vertexToName);
		}
	}
}