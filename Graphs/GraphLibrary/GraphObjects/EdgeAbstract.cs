namespace GraphLibrary.GraphObjects
{
	public abstract class EdgeAbstract
	{
		public virtual Vertex VertexFrom { get; set; }

		public virtual Vertex VertexTo { get; set; }

		public abstract string GetWeightString();
	}
}