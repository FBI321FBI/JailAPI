using CounterStrikeSharp.API.Modules.Menu;
using JailAPI.Interface.Model;
using System.Collections.Concurrent;

namespace JailAPI.Model
{
	public class MenuModel : IMenuModel
	{
		#region Prop
		/// <summary>
		/// Все менюшки.
		/// </summary>
		private static ConcurrentDictionary<string, IMenuModel> menus = null;
		public static ConcurrentDictionary<string, IMenuModel> Menus
		{
			get
			{
				if (menus is null)
				{
					Menus = new ConcurrentDictionary<string, IMenuModel>();
				}
				return menus;
			}
			private set
			{
				menus = value;
			}
		}

		public BaseMenu Menu { get; }

		public string? Description { get; init; }
        #endregion

        #region .ctor
        public MenuModel(BaseMenu menu, string description = null)
        {
            Menu = menu;
			Description = description;
        }
        #endregion

        #region Public
        public void RemoveMenu()
		{
			Menus.TryRemove(Menus.Where(x => x.Value == Menu).FirstOrDefault());
		}
		#endregion
	}
}
