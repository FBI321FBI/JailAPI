using JailAPI.Interface.Model;

namespace JailAPI.Interface.Services
{
	public interface ISerializationGuardFileService
	{
		/// <summary>
		/// Добавляет и обновляет файл Guards.json имя охранника, которое используется в плагине.
		/// </summary>
		/// <param name="model"></param>
		public void AddModel(ISerializationGuardsFileModel model);

		/// <summary>
		/// Обновляет существующий указанный JSON файл.
		/// Guards.json
		/// Menus.json
		/// </summary>
		/// <param name="nameFile">Название файла, например "Guards.json".</param>
		public void Update();
	}
}
