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
		public List<ModelScene> Models = new List<ModelScene>();
		public TypeMarker MarkerType;


		public enum TypeMarker
		{
			IMAGE, PATTERN, NOTMARKER
		}
	}
}
