using CounterStrikeSharp.API.Modules.Menu;

namespace JailAPI.Interface.Model
{
	public interface IMenuModel
	{
		/// <summary>
		/// Меню.
		/// </summary>
		BaseMenu Menu { get; }

		/// <summary>
		/// Описание меню.
		/// </summary>
		public string? Description { get; init; }

		/// <summary>
		/// Удаление меню из списка.
		/// </summary>
		/// <param name="player"></param>
		public void RemoveMenu();
	}
}
