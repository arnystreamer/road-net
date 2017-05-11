namespace RoadNet.Common.Geometry.Objects
{
	public class BendPoint : Point
	{
		public Path[] Paths { get; protected set; }

		public BendPoint()
		{
			Paths = new Path[2];
		}

		public BendPoint(Path path1, Path path2)
		{
			SetPaths(path1, path2);
		}

		public void SetPaths(Path path1, Path path2)
		{
			Paths[0] = path1;
			Paths[1] = path2;
		}
	}
}