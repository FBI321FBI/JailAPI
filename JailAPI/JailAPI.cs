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
		/// Сервис по работе с цветными игроками.
		/// </summary>
		public static IPlayerColorService PlayerColorService => new PlayerColorService();

		/// <summary>
		/// Сервис по работе с бунтовщиками.
		/// </summary>
		public static IRiotPlayerService RiotPlayerService => new RiotPlayerService();

		/// <summary>
		/// Сервис по работе с уникальными игроками.
		/// </summary>
		public static IUniquePlayerService UniquePlayerService => new UniquePlayerService();

		/// <summary>
		/// Сервис по работе с менюшками.
		/// </summary>
		public static IMenuService MenuService => new MenuService();

		/// <summary>
		/// Сервис для обновления JSON файлов (списков Guards и т.д.)
		/// </summary>
		public static ISerializationGuardFileService SerializationFileService => new SerializationGuardsFileService();
		#endregion
	}
}
