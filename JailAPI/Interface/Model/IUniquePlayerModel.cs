using CounterStrikeSharp.API.Core;

namespace JailAPI.Interface.Model
{
	public interface IUniquePlayerModel
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
		/// Описание уникального игрока.
		/// </summary>
		public string? Description { get; init; }

		/// <summary>
		/// Передать роль уникального игрока.
		/// </summary>
		/// <param name="player"></param>
		public void SubmitRole(CCSPlayerController? player);

		/// <summary>
		/// Уход с роли уникального игрока.
		/// </summary>
		public void LeaveRole();
	}
}
