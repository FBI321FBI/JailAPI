using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using JailAPI.Services;
using System.Collections.Concurrent;

namespace JailAPI.Model
{
	public class GuardModel : IGuardModel
	{
		#region Prop
		/// <summary>
		/// Все охранники.
		/// </summary>
		private static ConcurrentDictionary<string, IGuardModel> guards = null;
		public static ConcurrentDictionary<string, IGuardModel> Guards
		{
			get
			{
				if (guards is null)
				{
					Guards = new ConcurrentDictionary<string, IGuardModel>();
				}
				return guards;
			}
			private set
			{
				guards = value;
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

		private GuardService _guardService;
		#endregion

		#region .ctor
		/// <summary>
		/// Модель представления Simon.
		/// </summary>
		/// <param name="player"></param>
		public GuardModel(CCSPlayerController? player, string? description = null)
		{
			Player = player;
			PlayerPawn = player.PlayerPawn.Value;
			Description = description is null ? "" : description;
			_guardService = new GuardService();
		}

		#endregion

		#region Public
		public void LeavePost()
		{
			if(!Guards.TryRemove(Guards.Where(x => x.Value == this).FirstOrDefault()))
			{
				Console.WriteLine("[JailAPI] Охранник не был удалён. GuardModel.LeavePost");
			}
		}

		public void SubmitPost(CCSPlayerController? player)
		{
			var key = Guards.Where(x => x.Value == this).FirstOrDefault().Key;
			LeavePost();
			_guardService.CreateGuard(player, key);
		}
		#endregion
	}
}
