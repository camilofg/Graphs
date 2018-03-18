using GraphLibrary.Exceptions;
using GraphLibrary.Strategies.EdgeHandler;

namespace GraphLibrary.Factories
{
	public class EdgeHandlerFactory
	{
		private readonly Options _options;

		public EdgeHandlerFactory(Options options)
		{
			_options = options;
		}

		public IEdgeHandlerStrategy GetEdgeHandlerStrategy()
		{
			switch (_options.DirectionOption)
			{
				case DirectionEnum.Directed:
					return new DirectedEdgeHandler(new EdgeFactory(_options));

				case DirectionEnum.Undirected:
					return new UndirectedEdgeHandler(new EdgeFactory(_options));
			}

			throw new GraphException("Bad configuration for direction");
		}
	}
}