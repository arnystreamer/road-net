using System.Collections.Generic;
using RoadNet.Common.Geometry.Definitions;
using RoadNet.Common.Geometry.Primitives;

namespace RoadNet.Common.Geometry.Objects
{
	public abstract class Point : IWorldObject
	{
		public Position Position { get; set; }
		protected World World { get; set; }

		public List<Path> IncomingPaths { get; protected set; }
		public List<Path> OutcomingPaths { get; protected set; }

		public void AddIncomingPath(Path path)
		{
			IncomingPaths.Add(path);
		}

		public void RemoveIncomingPath(Path path)
		{
			IncomingPaths.Remove(path);
		}

		public void AddOutcomingPath(Path path)
		{
			OutcomingPaths.Add(path);
		}

		public void RemoveOutcomingPath(Path path)
		{
			OutcomingPaths.Remove(path);
		}

		public void Dispose()
		{
			
		}
	}
}