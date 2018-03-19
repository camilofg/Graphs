using System.Collections.Generic;
using System.Linq;

namespace GraphLibrary.GraphObjects
{
	public class Vertex
	{
		public Vertex()
		{
			Edges = new List<EdgeAbstract>();
		}

		public List<EdgeAbstract> Edges { get; set; }
		public string Name { get; set; }

		public string GetWeight(string vertexToName)
		{
			if (Name == vertexToName && Edges.All(e => e.VertexTo.Name != vertexToName)) return string.Empty;

			return Edges.First(e => e.VertexTo.Name == vertexToName).GetWeightString();
		}

		public bool HasPath(string vertexToName)
		{
			return Name != vertexToName && Edges.Any(e => e.VertexTo.Name == vertexToName);
		}

		public void RemoveEdgeTo(string vertexName)
		{
			Edges.RemoveAll(e => e.VertexTo.Name == vertexName);
		}
	}
}