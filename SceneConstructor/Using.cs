using System.Collections.Generic;

namespace SceneConstructor
{
	public class Using
	{
		public Position Position = new Position();
		public Position PositionLine = new Position();
		public Position PositionAfter = new Position();
		public string id = "";
		public List<ActionU> actions = new List<ActionU>();

		public override string ToString() { return id; }

	}
}