using System.Collections.Generic;
using RoadNet.Common.Geometry.Definitions;

namespace RoadNet.Common.Geometry
{
	public class World
	{
		private List<IWorldObject> Objects { get; set; }

		public World()
		{
			Objects = new List<IWorldObject>();
		}

		public void BindObject(IWorldObject obj)
		{
			Objects.Add(obj);
		}
	}
}