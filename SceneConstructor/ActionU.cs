using Newtonsoft.Json;
using System.Collections.Generic;

namespace SceneConstructor
{
	public class ActionU
	{
		public string Action = "";
		public string Name = "";


		[JsonExtensionData]
		Dictionary<string, object> fields = new Dictionary<string, object>();

		public override string ToString() { return Name; }
	}
}