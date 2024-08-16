using JailAPI.Interface.Services;
using JailAPI.Services;

namespace JailAPI
{
	public class JailApi
	{
		#region Services
		/// <summary>
		/// Сервис по работе с охранниками.
		/// </summary>
		public static IGuardService GuardService => new GuardService();

		/// <summary>
		/// Сервис для обновления JSON файлов (списков Guards и т.д.)
		/// </summary>
		public static ISerializationGuardFileService SerializationFileService => new SerializationGuardsFileService();
		#endregion
	}
}
