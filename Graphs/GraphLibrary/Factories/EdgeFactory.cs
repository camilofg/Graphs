using System.Collections.Generic;
using System.Linq;
using GraphLibrary.Exceptions;
using GraphLibrary.GraphObjects;

namespace GraphLibrary.Factories
{
	public class EdgeFactory
	{
		private readonly Options _options;

		public EdgeFactory(Options options)
		{
			_options = options;
		}

		public EdgeAbstract GetEdge(List<Vertex> vertexes, string vertexFromName, string vertexToName, int? weight)
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

			var edge = new Edge
			{
				VertexFrom = vertexFrom,
				VertexTo = vertexTo
			};

			if (_options.WheightOption == WeightEnum.Weighted)
			{
				if (!weight.HasValue)
				{
					throw new GraphException("Weight can no be null");
				}

				return new EdgeWeighted(edge, weight.Value);
			}

			return edge;
		}
	}
}