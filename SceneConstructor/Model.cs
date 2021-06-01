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
		public string title = "";
		public string subtitle = "";
		public string desc = "";
		public List<Using> anchors = new List<Using>();
		public List<object> exhibit_components = new List<object>();
		public List<string> pics = new List<string>();

		public override string ToString() { return title; }

	}
}
