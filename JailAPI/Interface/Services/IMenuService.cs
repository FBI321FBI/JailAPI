using CounterStrikeSharp.API.Modules.Menu;
using JailAPI.Interface.Model;

namespace JailAPI.Interface.Services
{
	public interface IMenuService
	{
		/// <summary>
		/// Добавление менюшки в список API.
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="name"></param>
		public void AddMenu(IMenuModel menu, string name);

		/// <summary>
		/// Удаление меню из списка API.
		/// </summary>
		/// <param name="menu"></param>
		public void RemoveMenu(BaseMenu menu);

		/// <summary>
		/// Удаление меню из списка API.
		/// </summary>
		/// <param name="name"></param>
		public void RemoveMenu(string name);

		/// <summary>
		/// Получение меню из списка.
		/// </summary>
		/// <param name="menu"></param>
		/// <returns></returns>
		public IMenuModel GetMenu(BaseMenu menu);

		/// <summary>
		/// Получение меню из списка.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public IMenuModel GetMenu(string name);
	}
}
