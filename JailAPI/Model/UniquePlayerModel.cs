using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Services;
using System.Collections.Concurrent;

namespace JailAPI.Model
{
	public class UniquePlayerModel : IUniquePlayerModel
	{
		#region Prop
		/// <summary>
		/// Уникальные игроки.
		/// </summary>
		private static ConcurrentDictionary<string, IUniquePlayerModel> uniquePlayers = null;
		public static ConcurrentDictionary<string, IUniquePlayerModel> UniquePlayers
		{
			get
			{
				if (uniquePlayers is null)
				{
					UniquePlayers = new ConcurrentDictionary<string, IUniquePlayerModel>();
				}
				return uniquePlayers;
			}
			private set
			{
				uniquePlayers = value;
			}
		}

		private CCSPlayerController? player = null;
		public CCSPlayerController? Player
		{
			get
			{
				return player;
			}
			set
			{
				player = value;
			}
		}

		private CCSPlayerPawn? playerPawn = null;
		public CCSPlayerPawn? PlayerPawn
		{
			get
			{
				return playerPawn;
			}
			set
			{
				playerPawn = value;
			}
		}

		public string? Description { get; init; }

		private IUniquePlayerService _uniquePlayerService;
		#endregion

		#region .ctor
		public UniquePlayerModel(CCSPlayerController? player, string? description = null)
        {
			Player = player;
			PlayerPawn = player.PlayerPawn.Value;
			Description = description is null ? "" : description;
			_uniquePlayerService = new UniquePlayerService();
		}
        #endregion

        #region Public
        public void LeaveRole()
		{
			if(!UniquePlayers.TryRemove(UniquePlayers.Where(x => x.Value == this).FirstOrDefault()))
			{
				Console.WriteLine("[JailAPI] Уникальный игрок не был удалён. UniquePlayerModel.LeaveRole");
			}
		}

		public void SubmitRole(CCSPlayerController? player)
		{
			var key = UniquePlayers.Where(x => x.Value == this).FirstOrDefault().Key;
			LeaveRole();
			_uniquePlayerService.CreateUniquePlayer(player, key, Description);
		}
		#endregion
	}
}
