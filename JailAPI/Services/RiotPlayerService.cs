using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Model;
using System.Drawing;

namespace JailAPI.Services
{
	public class RiotPlayerService : IRiotPlayerService
	{
		public void ApplyColoring(CCSPlayerController player)
		{
			var riotPlayer = RiotPlayerModel.PlayersRiot.Where(x => x.Player == player).FirstOrDefault();
			if (riotPlayer is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. RiotPlayerService.ApplyColoring.");
			}
			else
			{
				riotPlayer.ApplyColoring();
			}
		}

		public void ApplyColoringByColor(Color color)
		{
			var riotPlayers = PlayerColorModel.PlayersColor.Where(x => x.Color == color).ToList();
			if (riotPlayers is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. RiotPlayerService.ApplyColoringByColor.");
				return;
			}

			foreach (var riotPlayer in riotPlayers)
			{
				riotPlayer.ApplyColoring();
			}
		}

		public void ClearColor(CCSPlayerController player)
		{
			var riotPlayer = RiotPlayerModel.PlayersRiot.Where(x => x.Player == player).FirstOrDefault();
			if (riotPlayer is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. RiotPlayerService.ClearColor.");
			}
			else
			{
				riotPlayer.ClearColor();
			}
		}

		public void ClearColorAndRemove(CCSPlayerController player)
		{
			var riotPlayer = RiotPlayerModel.PlayersRiot.Where(x => x.Player == player).FirstOrDefault();
			if (riotPlayer is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. RiotPlayerService.ClearColorAndRemove.");
			}
			else
			{
				riotPlayer.ClearColorAndRemove();
			}
		}

		public void ClearColorAndRemoveByColor(Color color)
		{
			var riotPlayers = RiotPlayerModel.PlayersRiot.Where(x => x.Color == color).ToList();
			if (riotPlayers is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. RiotPlayerService.ClearColorAndRemoveByColor.");
				return;
			}

			foreach (var riotPlayer in riotPlayers)
			{
				riotPlayer.ClearColorAndRemove();
			}
		}

		public void ClearColorAndRemoveForAll()
		{
			foreach (var riotPlayers in RiotPlayerModel.PlayersRiot)
			{
				riotPlayers.ClearColorAndRemove();
			}
		}

		public void ClearColorByColor(Color color)
		{
			var riotPlayers = RiotPlayerModel.PlayersRiot.Where(x => x.Color == color).ToList();
			if (riotPlayers is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. RiotPlayerService.ClearColorByColor.");
				return;
			}

			foreach (var riotPlayer in riotPlayers)
			{
				riotPlayer.ClearColor();
			}
		}

		public void ClearColorForAll()
		{
			foreach (var riotPlayer in RiotPlayerModel.PlayersRiot)
			{
				riotPlayer.ClearColor();
			}
		}

		public void CreateRiotPlayer(CCSPlayerController player, Color color)
		{
			IRiotPlayerModel riotPlayer = new RiotPlayerModel(player, color);
			foreach (var _riotPlayer in RiotPlayerModel.PlayersRiot)
			{
				if (_riotPlayer.Player == player)
				{
					_riotPlayer.ClearColorAndRemove();
					break;
				}
			}
			RiotPlayerModel.PlayersRiot.Add(riotPlayer);
		}

		public IRiotPlayerModel GetRiotPlayerModelByPlayer(CCSPlayerController player)
		{
			var riotPlayer = RiotPlayerModel.PlayersRiot.Where(x => x.Player == player).FirstOrDefault();
			return riotPlayer;
		}

		public void RefreshColorForPlayerAndApply(CCSPlayerController player, Color color)
		{
			var model = GetRiotPlayerModelByPlayer(player);
			model.RefreshColorAndApply(color);
		}
	}
}
