using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Model;
using System.Drawing;

namespace JailAPI.Services
{
	public class FreedayPlayerService : IFreedayPlayerService
	{
		public void ApplyColoring(CCSPlayerController player)
		{
			var freedayPlayer = FreedayPlayerModel.FreedayPlayers.Where(x => x.Player == player).FirstOrDefault();
			if (freedayPlayer is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. FreedayPlayerModel.ApplyColoring.");
			}
			else
			{
				freedayPlayer.ApplyColoring();
			}
		}

		public void ApplyColoringByColor(Color color)
		{
			var freedayPlayers = PlayerColorModel.PlayersColor.Where(x => x.Color == color).ToList();
			if (freedayPlayers is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorModel.ApplyColoringByColor.");
				return;
			}

			foreach (var freedayPlayer in freedayPlayers)
			{
				freedayPlayer.ApplyColoring();
			}
		}

		public void ClearColor(CCSPlayerController player)
		{
			var freedayPlayer = FreedayPlayerModel.FreedayPlayers.Where(x => x.Player == player).FirstOrDefault();
			if (freedayPlayer is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. FreedayPlayerModel.ClearColor.");
			}
			else
			{
				freedayPlayer.ClearColor();
			}
		}

		public void ClearColorAndRemove(CCSPlayerController player)
		{
			var freedayPlayer = FreedayPlayerModel.FreedayPlayers.Where(x => x.Player == player).FirstOrDefault();
			if (freedayPlayer is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. FreedayPlayerService.ClearColorAndRemove.");
			}
			else
			{
				freedayPlayer.ClearColorAndRemove();
			}
		}

		public void ClearColorAndRemoveByColor(Color color)
		{
			var freedayPlayers = FreedayPlayerModel.FreedayPlayers.Where(x => x.Color == color).ToList();
			if (freedayPlayers is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. FreedayPlayerService.ClearColorAndRemoveByColor.");
				return;
			}

			foreach (var freedayPlayer in freedayPlayers)
			{
				freedayPlayer.ClearColorAndRemove();
			}
		}

		public void ClearColorAndRemoveForAll()
		{
			foreach (var freedayPlayers in FreedayPlayerModel.FreedayPlayers)
			{
				freedayPlayers.ClearColorAndRemove();
			}
		}

		public void ClearColorByColor(Color color)
		{
			var freedayPlayers = FreedayPlayerModel.FreedayPlayers.Where(x => x.Color == color).ToList();
			if (freedayPlayers is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. FreedayPlayerService.ClearColorByColor.");
				return;
			}

			foreach (var freedayPlayer in freedayPlayers)
			{
				freedayPlayer.ClearColor();
			}
		}

		public void ClearColorForAll()
		{
			foreach (var freedayPlayer in FreedayPlayerModel.FreedayPlayers)
			{
				freedayPlayer.ClearColor();
			}
		}

		public void CreateFreedayPlayer(CCSPlayerController player, Color color)
		{
			IFreedayPlayerModel freedayPlayer = new FreedayPlayerModel(player, color);
			foreach (var _freedayPlayer in FreedayPlayerModel.FreedayPlayers)
			{
				if (_freedayPlayer.Player == player)
				{
					_freedayPlayer.ClearColorAndRemove();
					break;
				}
			}
			FreedayPlayerModel.FreedayPlayers.Add(freedayPlayer);
		}

		public IFreedayPlayerModel GetFreedayPlayerModelByPlayer(CCSPlayerController player)
		{
			var freedayPlayer = FreedayPlayerModel.FreedayPlayers.Where(x => x.Player == player).FirstOrDefault();
			return freedayPlayer;
		}

		public void RefreshColorForPlayerAndApply(CCSPlayerController player, Color color)
		{
			var model = GetFreedayPlayerModelByPlayer(player);
			model.RefreshColorAndApply(color);
		}
	}
}
