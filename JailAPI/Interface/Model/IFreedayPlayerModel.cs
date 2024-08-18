using System.Drawing;

namespace JailAPI.Interface.Model
{
	public interface IFreedayPlayerModel : IPlayerModel
	{
		/// <summary>
		/// Цвет.
		/// </summary>
		public Color Color { get; }

		/// <summary>
		/// Окрасить игрока.
		/// </summary>
		public void ApplyColoring();

		/// <summary>
		/// Убрать окраску игрока.
		/// </summary>
		public void ClearColor();

		/// <summary>
		/// Убрать окраску игрока. И удалить его из FreeDayPlayers.
		/// </summary>
		public void ClearColorAndRemove();

		/// <summary>
		/// Обновить цвет игрока и применить.
		/// </summary>
		/// <param name="color"></param>
		public void RefreshColorAndApply(Color color);
	}
}