using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SceneConstructor
{
	public class Model
	{
		public string GUID = "";
		public string Name = "";
		public List<Using> Usings = new List<Using>();

	

		public override string ToString() { return Name; }


	}
}
