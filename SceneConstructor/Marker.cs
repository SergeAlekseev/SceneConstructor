using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneConstructor
{
	public class Marker
	{
		public string GUID = "";
		public string Name = "";
		public List<ModelScene> Models = new List<ModelScene>();
		public string MarkerType = "HIRO";

		public override string ToString() { return Name; }

	}
}
