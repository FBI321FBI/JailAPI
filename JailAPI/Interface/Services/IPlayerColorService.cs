using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Drawing;

namespace JailAPI.Interface.Services
{
	public interface IPlayerColorService
	{
		/// <summary>
		/// Создание цветного игрока.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="color"></param>
		public void CreatePlayerColor(CCSPlayerController player, Color color);

		/// <summary>
		/// Получение цветного игрока.
		/// </summary>
		/// <param name="player"></param>
		/// <returns></returns>
		public IPlayerColorModel GetPlayerColorModelByPlayer(CCSPlayerController player);

		/// <summary>
		/// Получение цветного игрока по цвету.
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public List<IPlayerColorModel> GetPlayerColorModelByColor(Color color);

		/// <summary>
		/// Окрасить игрока.
		/// </summary>
		/// <param name="player"></param>
		public void ApplyColoring(CCSPlayerController player);

		/// <summary>
		/// Окрасить игрока.
		/// </summary>
		/// <param name="model"></param>
		public void ApplyColoring(IPlayerColorModel model);

		/// <summary>
		/// Окрасить игрока по цвету.
		/// </summary>
		/// <param name="color"></param>
		public void ApplyColoringByColor(Color color);

		/// <summary>
		/// Убрать окраску игрока.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColor(CCSPlayerController player);

		/// <summary>
		/// Убрать окраску игрока.
		/// </summary>
		/// <param name="model"></param>
		public void ClearColor(IPlayerColorModel model);

		/// <summary>
		/// Убрать окраску игрока по цвету.
		/// </summary>
		/// <param name="color"></param>
		public void ClearColorByColor(Color color);

		/// <summary>
		/// Убрать окраску игрока. И удалить его из PlayerColors.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColorAndRemove(CCSPlayerController player);

		/// <summary>
		/// Убрать окраску игрока. И удалить его из PlayerColors.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColorAndRemove(IPlayerColorModel model);

		/// <summary>
		/// Убрать окраску игрока по цвету. И удалить его из PlayerColors.
		/// </summary>
		/// <param name="color"></param>
		public void ClearColorAndRemoveByColor(Color color);
	}
}
