namespace GraphLibrary.GraphObjects
{
	public class EdgeWeighted : EdgeDecorator
	{
		public EdgeWeighted(EdgeAbstract edge, int weight) : base(edge)
		{
			Weight = weight;
		}

		public override Vertex VertexFrom => _edge.VertexFrom;
		public override Vertex VertexTo => _edge.VertexTo;
		public int Weight { get; set; }

		public override string GetWeightString()
		{
			return Weight.ToString();
		}
	}
}