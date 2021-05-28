﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneConstructor
{

	public class Scene
	{
		public string GUID = "";
		public string Name = "";
		public List<Marker> Markers = new List<Marker>();
		public List<ModelScene> OtherModels = new List<ModelScene>();


		[JsonIgnore]
		public List<ActionType> actionTypes = new List<ActionType>();

		public string TypeMarkers = "PATTERN";

		public Scene()
		{
			try
			{
				string data = File.ReadAllText(Environment.CurrentDirectory + "\\ActionTypes.json");
				if (data != "")
					actionTypes = JsonConvert.DeserializeObject<List<ActionType>>(data);
			}
			catch
			{
				StreamWriter file = File.CreateText(Environment.CurrentDirectory + "\\ActionTypes.json");
				file.Close();
			};
		}

		public void saveActionTypes()
		{
			string output = JsonConvert.SerializeObject(actionTypes);
			StreamWriter file = File.CreateText(Environment.CurrentDirectory + "\\ActionTypes.json");
			file.Write(output);
			file.Close();
		}
	}



}
