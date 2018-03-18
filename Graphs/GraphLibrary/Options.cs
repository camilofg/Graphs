namespace GraphLibrary
{
	public enum DirectionEnum
	{
		Directed,
		Undirected
	}

	public enum SearchEnum
	{
		NoSearch,
		Dfs,
		Bfs
	}

	public enum WeightEnum
	{
		Weighted,
		Unweighted
	}

	public class Options
	{
		public DirectionEnum DirectionOption { get; set; }
		public SearchEnum SearchOption { get; set; }
		public WeightEnum WheightOption { get; set; }
	}
}