using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace JailAPI.Services
{
	public class SerializationGuardsFileService : ISerializationGuardFileService
	{
		#region Prop
		private List<ISerializationGuardsFileModel> _serializationGuardFiles { get; }
		#endregion

		#region .ctor
		public SerializationGuardsFileService()
        {
			_serializationGuardFiles = new List<ISerializationGuardsFileModel>();
		}
		#endregion

		#region Public
		public void Update()
		{
			string path = @$"..\..\csgo\addons\counterstrikesharp\shared\JailAPI\Guards.json";
			JObject? JsonItems = null;

			if (File.Exists(path) && new FileInfo(path).Length > 0)
			{
				JsonItems = JObject.Parse(File.ReadAllText(path));
			}

			using (StreamWriter writer = new StreamWriter(path, append: true, encoding: System.Text.Encoding.UTF8))
			{
				foreach (var file in _serializationGuardFiles) // Берём каждый элемент из списка.
				{
					if(new FileInfo(path).Length > 0)
					{
						writer.WriteLine(JsonSerializer.Serialize(file));
					}
					else
					{
						foreach (var element in JsonItems.Properties().Where(x => x.Value is JObject)) // Берём каждый элемент из Json файла.
						{
							if (element.Value["Name"].ToString() == file.Name) // Если элемент уже есть в Json файле, то пропускаем.
							{
								break;
							}
							writer.WriteLine(JsonSerializer.Serialize(file)); // Если нет элемента, то записываем его.
						}
					}
				}
			}
		}

		public void AddModel(ISerializationGuardsFileModel model)
		{
			_serializationGuardFiles.Add(model);
			Update();
		}
		#endregion
	}
}
