using Newtonsoft.Json;
using System.Collections.Generic;

namespace SceneConstructor
{
	public class ActionU
	{
		public string action = "";
		public string name = "";


		[JsonExtensionData]
		public Dictionary<string, object> fields = new Dictionary<string, object>();

		public override string ToString() { return name; }
	}
}