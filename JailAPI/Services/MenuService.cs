using CounterStrikeSharp.API.Modules.Menu;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Model;

namespace JailAPI.Services
{
	public class MenuService : IMenuService
	{
		/// <summary>
		/// Добавление меню в словарь JailAPI.
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="name"></param>
		public void AddMenu(ref IMenuModel menu, string name)
		{
			if(!MenuModel.Menus.TryAdd(name, menu))
			{
				RemoveMenu(name);
				MenuModel.Menus.TryAdd(name, menu);
			}
		}

		/// <summary>
		/// Получение меню из словаря JailAPI.
		/// </summary>
		/// <param name="menu"></param>
		/// <returns></returns>
		public IMenuModel? GetMenu(BaseMenu menu)
		{
			foreach (var item in MenuModel.Menus)
			{
				if (menu == item.Value.Menu)
				{
					MenuModel.Menus.TryGetValue(item.Key, out IMenuModel value);
					return value;
				}
			}
			Console.WriteLine($"[JailAPI] Не существует меню под item: {menu}. MenuService.GetMenu");
			return null;
		}

		/// <summary>
		/// Получение меню из словаря JailAPI.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public IMenuModel? GetMenu(string name)
		{
			if (MenuModel.Menus.TryGetValue(name, out IMenuModel value))
			{
				return value;
			}
			else
			{
				Console.WriteLine($"[JailAPI] Не существует меню под key: {name}. MenuService.GetMenu");
				return null;
			}
		}

		/// <summary>
		/// Удаление меню из словаря.
		/// </summary>
		/// <param name="menu"></param>
		public void RemoveMenu(BaseMenu menu)
		{
			foreach (var item in MenuModel.Menus)
			{
				if (menu == item.Value.Menu)
				{
					item.Value.RemoveMenu();
					return;
				}
			}
			Console.WriteLine($"[JailAPI] Не существует меню под item: {menu}. MenuService.RemoveMenu");
			return;
		}

		/// <summary>
		/// Удаление меню из словаря.
		/// </summary>
		/// <param name="name"></param>
		public void RemoveMenu(string name)
		{
			if (MenuModel.Menus.TryRemove(name, out IMenuModel _))
			{
				return;
			}
			else
			{
				Console.WriteLine($"[JailAPI] Не существует меню под key: {name}. MenuService.RemoveMenu");
				return;
			}
		}
	}
}
