using GraphLibrary.Exceptions;
using GraphLibrary.Strategies.SearchStrategy;

namespace GraphLibrary.Factories
{
	public class SearchFactory
	{
		private readonly Options _options;

		public SearchFactory(Options options)
		{
			_options = options;
		}

		public ISearchStrategy GetSearchStrategy()
		{
			switch (_options.SearchOption)
			{
				case SearchEnum.NoSearch:
					return new NoSearchStrategy();

				case SearchEnum.Dfs:
					return new DfsSearchStrategy();

				case SearchEnum.Bfs:
					return new BfsSearchStrategy();
			}

			throw new GraphException("Bad configuration for Search");
		}
	}
}