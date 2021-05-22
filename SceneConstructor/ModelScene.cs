using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneConstructor
{
	public class ModelScene
	{
		public string GUID;
		public string Size;
		public string Position;

		[JsonIgnore]
		public Model model;

	}
}
