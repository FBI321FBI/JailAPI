using CounterStrikeSharp.API.Core;

namespace JailAPI.Interface.Model
{
	public interface IPlayerModel
	{
		/// <summary>
		/// Игрок.
		/// </summary>
		public CCSPlayerController? Player { get; }

		/// <summary>
		/// Пешка игрока.
		/// </summary>
		public CCSPlayerPawn? PlayerPawn { get; }
	}
}
