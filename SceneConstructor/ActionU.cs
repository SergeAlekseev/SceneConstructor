using Newtonsoft.Json;
using System.Collections.Generic;

namespace SceneConstructor
{
	public class ActionU
	{
		public string Action = "";

		[JsonExtensionData]
		Dictionary<string, object> fields = new Dictionary<string, object>();

	}
}