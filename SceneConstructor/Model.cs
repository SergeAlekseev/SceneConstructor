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
		public string GUID;
		public string Size;
		public List<Using> Usings = new List<Using>();

		public Model(string path, string name)
		{
			this.GUID = path;
			this.Size = name;
		}

		

	}
}
