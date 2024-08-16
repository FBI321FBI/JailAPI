using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Entities;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Model;
using System.Drawing;
using System.Numerics;

namespace JailAPI.Services
{
	public class PlayerColorService : IPlayerColorService
	{
		public void ApplyColoring(CCSPlayerController player)
		{
			var playerColor = PlayerColorModel.PlayersColor.Where(x => x.Player == player).FirstOrDefault();
			if(playerColor is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorService.ApplyColoring.");
			}
			else
			{
				playerColor.ApplyColoring();
			}
		}

		public void ApplyColoring(IPlayerColorModel model)
		{
			model.ApplyColoring();
		}

		public void ApplyColoringByColor(Color color)
		{
			var playersColor = PlayerColorModel.PlayersColor.Where(x => x.Color == color).ToList();
			if(playersColor is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorService.ApplyColoringByColor.");
				return;
			}

			foreach(var playerColor in playersColor)
			{
				playerColor.ApplyColoring();
			}
		}

		public void ClearColor(CCSPlayerController player)
		{
			var playerColor = PlayerColorModel.PlayersColor.Where(x => x.Player == player).FirstOrDefault();
			if (playerColor is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorService.ClearColor.");
			}
			else
			{
				playerColor.ClearColor();
			}
		}

		public void ClearColor(IPlayerColorModel model)
		{
			model.ClearColor();
		}

		public void ClearColorAndRemove(CCSPlayerController player)
		{
			var playerColor = PlayerColorModel.PlayersColor.Where(x => x.Player == player).FirstOrDefault();
			if (playerColor is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorService.ClearColorAndRemove.");
			}
			else
			{
				playerColor.ClearColorAndRemove();
			}
		}

		public void ClearColorAndRemove(IPlayerColorModel model)
		{
			model.ClearColorAndRemove();
		}

		public void ClearColorAndRemoveByColor(Color color)
		{
			var playersColor = PlayerColorModel.PlayersColor.Where(x => x.Color == color).ToList();
			if (playersColor is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorService.ClearColorAndRemoveByColor.");
				return;
			}

			foreach (var playerColor in playersColor)
			{
				playerColor.ClearColorAndRemove();
			}
		}

		public void ClearColorByColor(Color color)
		{
			var playersColor = PlayerColorModel.PlayersColor.Where(x => x.Color == color).ToList();
			if (playersColor is null)
			{
				Console.WriteLine("[JailAPI] [NULL] Цвет игрока не смог примениться на игрока. PlayerColorService.ClearColorAndRemoveByColor.");
				return;
			}

			foreach (var playerColor in playersColor)
			{
				playerColor.ClearColor();
			}
		}

		public void CreatePlayerColor(CCSPlayerController player, Color color)
		{
			IPlayerColorModel playerColor = new PlayerColorModel(player, color);
			foreach(var _playerColor in PlayerColorModel.PlayersColor)
			{
				if(_playerColor.Player == player)
				{
					_playerColor.ClearColorAndRemove();
					break;
				}
			}
			PlayerColorModel.PlayersColor.Add(playerColor);
		}

		public IPlayerColorModel? GetPlayerColorModelByPlayer(CCSPlayerController player)
		{
			var playersColor = PlayerColorModel.PlayersColor.Where(x => x.Player == player).FirstOrDefault();
			return playersColor;
		}

		public List<IPlayerColorModel>? GetPlayerColorModelByColor(Color color)
		{
			var playersColor = PlayerColorModel.PlayersColor.Where(x => x.Color == color).ToList();
			return playersColor;
		}

		//refresh color PlayerColor
	}
}
