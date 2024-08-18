using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Drawing;

namespace JailAPI.Interface.Services
{
	public interface IFreedayPlayerService
	{
		/// <summary>
		/// Создание фридейщика.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="color"></param>
		public void CreateFreedayPlayer(CCSPlayerController player, Color color);

		/// <summary>
		/// Получение фридейщика.
		/// </summary>
		/// <param name="player"></param>
		/// <returns></returns>
		public IFreedayPlayerModel GetFreedayPlayerModelByPlayer(CCSPlayerController player);

		/// <summary>
		/// Окрасить игрока.
		/// </summary>
		/// <param name="player"></param>
		public void ApplyColoring(CCSPlayerController player);

		/// <summary>
		/// Окрасить фридейщика по цвету.
		/// </summary>
		/// <param name="color"></param>
		public void ApplyColoringByColor(Color color);

		/// <summary>
		/// Убрать окраску фридейщика.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColor(CCSPlayerController player);

		/// <summary>
		/// Убрать окраску фридейщика по цвету.
		/// </summary>
		/// <param name="color"></param>
		public void ClearColorByColor(Color color);

		/// <summary>
		/// Убрать окраску фридейщика. И удалить его из FreedayPlayers.
		/// </summary>
		/// <param name="player"></param>
		public void ClearColorAndRemove(CCSPlayerController player);

		/// <summary>
		/// Убрать окраску фридейщика по цвету. И удалить его из FreedayPlayers.
		/// </summary>
		/// <param name="color"></param>
		public void ClearColorAndRemoveByColor(Color color);

		/// <summary>
		/// Очистить всех фридейщиков.
		/// </summary>
		public void ClearColorForAll();

		/// <summary>
		/// Очистить и удалить всех фридейщиков.
		/// </summary>
		public void ClearColorAndRemoveForAll();

		/// <summary>
		/// Обновляет цвет фридейщика и применить.
		/// </summary>
		/// <param name="player"></param>
		public void RefreshColorForPlayerAndApply(CCSPlayerController player, Color color);
	}
}