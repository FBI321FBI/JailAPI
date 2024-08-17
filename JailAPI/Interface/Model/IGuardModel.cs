using CounterStrikeSharp.API.Core;

namespace JailAPI.Interface.Model
{
	public interface IGuardModel
	{
		/// <summary>
		/// Игрок.
		/// </summary>
		public CCSPlayerController? Player { get; }

		/// <summary>
		/// Пешка игрока.
		/// </summary>
		public CCSPlayerPawn? PlayerPawn { get; }

		/// <summary>
		/// Описание охранника.
		/// </summary>
		public string? Description { get; init; }

		/// <summary>
		/// Передать пост.
		/// </summary>
		/// <param name="player"></param>
		public void SubmitPost(CCSPlayerController? player);

		/// <summary>
		/// Уход с поста.
		/// </summary>
		public void LeavePost();
	}
}
