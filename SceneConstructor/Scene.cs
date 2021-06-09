using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SceneConstructor
{

	public class Scene
	{
		public string name = "";
		public string title = "";
		public string subtitle = "";
		public List<Marker> markers = new List<Marker>();


		[JsonIgnore]
		public List<ActionType> actionTypes = new List<ActionType>();

		public string typeMarkers = "PATTERN";

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

		public void saveScene()
		{
			string output = JsonConvert.SerializeObject(this);
			Directory.CreateDirectory(Environment.CurrentDirectory + "\\scenes");
			StreamWriter file = File.CreateText(Environment.CurrentDirectory + "\\scenes\\" + this.name + ".json");
			file.Write(output);
			file.Close();
			foreach (Marker marker in this.markers)
			{
				foreach (ModelScene model in marker.models)
				{
					string str = JsonConvert.SerializeObject(model.model);
					StreamWriter fileSer = File.CreateText(Environment.CurrentDirectory + "\\resources\\models\\" + model.id + ".json");
					fileSer.Write(str);
					fileSer.Close();
				}
			}

			string fileTextVR = File.ReadAllText(Environment.CurrentDirectory + "\\resources\\vr.html");
			string[] fileSplitVR = fileTextVR.Split(new string[] { "<head>" }, StringSplitOptions.RemoveEmptyEntries);
			string vrTextVR = fileSplitVR[0] + " <head> ";

			string fileTextAR = File.ReadAllText(Environment.CurrentDirectory + "\\resources\\ar.html");
			string[] fileSplitAR = fileTextAR.Split(new string[] { "<head>" }, StringSplitOptions.RemoveEmptyEntries);
			string vrTextAR = fileSplitAR[0] + " <head> ";

			foreach (ActionType at in actionTypes)
			{
				string script = "<script src = \"resources/components/actions/" + at.name + ".js\"></script> ";
				vrTextVR += script;
				vrTextAR += script;
			}

			vrTextVR += fileSplitVR[1];
			vrTextAR += fileTextAR[1];

			StreamWriter fileVR = File.CreateText(Environment.CurrentDirectory + "\\vr_mode.html");
			fileVR.Write(vrTextVR);
			fileVR.Close();

			StreamWriter fileAR = File.CreateText(Environment.CurrentDirectory + "\\ar_mode.html");
			fileAR.Write(vrTextAR);
			fileAR.Close();
		}

		public static Scene openScene(string filename)
		{
			string fileText = File.ReadAllText(filename);
			Scene scene = JsonConvert.DeserializeObject<Scene>(fileText);
			foreach (Marker marker in scene.markers)
			{
				foreach (ModelScene model in marker.models)
				{
					try
					{
						string fileModelText = File.ReadAllText(Environment.CurrentDirectory + "\\resources\\models\\" + model.id + ".json");
						model.model = JsonConvert.DeserializeObject<Model>(fileModelText);
					}
					catch { }
				}
			}

			return scene;
		}

		internal ActionType getActionType(ActionU actionU)
		{
			foreach (ActionType at in actionTypes)
			{
				if (at.name == actionU.action)
					return at;
			}
			return null;
		}
	}



}
