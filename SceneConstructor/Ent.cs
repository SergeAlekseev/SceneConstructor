using System.Collections.Generic;

namespace SceneConstructor
{
	public class Ent
	{
		public string Name = "";
		public string Type = "Number";
		public List<Ent> ents = new List<Ent>();

		public override string ToString() { return Name +" ("+Type+")"; }

	}
}