using System.Collections.Generic;

namespace SceneConstructor
{
	public class Using
	{
		public string GUID = "";
		public string Position = "";
		public string PositionLine = "";
		public string PositionAfter = "";
		public string Name = "";
		public List<ActionU> Actions = new List<ActionU>();

		public override string ToString() { return Name; }

	}
}