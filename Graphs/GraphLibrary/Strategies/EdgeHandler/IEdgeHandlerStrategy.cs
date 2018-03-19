using System.Collections.Generic;
using GraphLibrary.GraphObjects;

namespace GraphLibrary.Strategies.EdgeHandler
{
	public interface IEdgeHandlerStrategy
	{
		EdgeAbstract AddEdge(List<Vertex> vertexes, string vertexFromName, string vertexToName, int? weight);

		void RemoveEdge(List<Vertex> vertexes, string vertexFromName, string vertexToName);
	}
}