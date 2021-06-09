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
		public string id = "";
		public Position size = new Position();
		public Position position = new Position();
		public Position markerOffset = new Position();
		public string GUID = "";

		


		[JsonIgnore]
		public Model model = new Model();

		public ModelScene()
		{
			GUID = Guid.NewGuid().ToString();
		}


		public override string ToString() { return id; }

	}
}
