using System.Collections.Generic;

namespace SceneConstructor
{
	public class Marker
	{
		public string id = "";
		public string markerValue = "";
		public List<ModelScene> models = new List<ModelScene>();
		public string markerType = "hiro";
		

		public override string ToString() { return markerValue; }

	}
}
