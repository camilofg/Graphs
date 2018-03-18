namespace GraphLibrary.GraphObjects
{
	public abstract class EdgeDecorator : EdgeAbstract
	{
		protected EdgeAbstract _edge;

		protected EdgeDecorator(EdgeAbstract edge)
		{
			_edge = edge;
		}
	}
}