using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneConstructor
{
	public class ActionType
	{

		public string path = "";
		public string name = "";
		public List<Ent> fields = new List<Ent>();

		public override string ToString() { return name; }


	}
}
