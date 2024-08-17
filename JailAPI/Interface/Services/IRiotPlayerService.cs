using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Drawing;

namespace JailAPI.Interface.Services
{
	public interface IRiotPlayerService
	{
		/// <summary>
		/// Создание бунтовщика.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="color"></param>
		public void CreateRiotPlayer(CCSPlayerController player, Color color);

		/// <summary>
		/// Получение бунтовщика.
		/// </summary>
		/// <param name="player"></param>
		/// <returns></returns>
		public IRiotPlayerModel GetRiotPlayerModelByPlayer(CCSPlayerController player);

		/// <summary>
		/// Окрасить игрока.
		/// </summary>
		/// <param name="player"></param>
		public void ApplyColoring(CCSPlayerController player);

		/// <summary>
		/// Окрасить бунтовщика по цвету.
		/// </summary>
		/// <param name="color"></param>
		public void ApplyColoringByColor(Color color);

		/// <summary>
		/// Убрать окраску бунтовщика.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColor(CCSPlayerController player);

		/// <summary>
		/// Убрать окраску бунтовщика по цвету.
		/// </summary>
		/// <param name="color"></param>
		public void ClearColorByColor(Color color);

		/// <summary>
		/// Убрать окраску бунтовщика. И удалить его из PlayersRiot.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColorAndRemove(CCSPlayerController player);

		/// <summary>
		/// Убрать окраску бунтовщика по цвету. И удалить его из PlayersRiot.
		/// </summary>
		/// <param name="color"></param>
		public void ClearColorAndRemoveByColor(Color color);

		/// <summary>
		/// Очистить всех бунтовщиков.
		/// </summary>
		public void ClearColorForAll();

		/// <summary>
		/// Очистить и удалить всех бунтовщиков.
		/// </summary>
		public void ClearColorAndRemoveForAll();

		/// <summary>
		/// Обновляет цвет бунтовщику и применить.
		/// </summary>
		/// <param name="player"></param>
		public void RefreshColorForPlayerAndApply(CCSPlayerController player, Color color);
	}
}
