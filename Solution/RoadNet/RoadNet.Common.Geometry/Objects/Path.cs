using RoadNet.Common.Geometry.Definitions;
using RoadNet.Common.Geometry.Enum;

namespace RoadNet.Common.Geometry.Objects
{
	public class Path : IWorldObject
	{
		private readonly Point _point1;
		private readonly Point _point2;

		public Path(Point point1, Point point2, Direction direction)
		{
			_point1 = point1;
			_point2 = point2;

			if (direction == Direction.Forward || direction == Direction.TwoWay)
			{
				point1.AddOutcomingPath(this);
				point2.AddIncomingPath(this);
			}

			if (direction == Direction.Inverse || direction == Direction.TwoWay)
			{
				point1.AddIncomingPath(this);
				point2.AddOutcomingPath(this);
			}
		}

		public void Dispose()
		{
			_point1.RemoveOutcomingPath(this);
			_point2.RemoveIncomingPath(this);

			_point1.RemoveIncomingPath(this);
			_point2.RemoveOutcomingPath(this);
		}
	}
}