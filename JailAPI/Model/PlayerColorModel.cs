using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Drawing;

namespace JailAPI.Model
{
	public class PlayerColorModel : IPlayerColorModel
	{
		#region Prop
		private static List<IPlayerColorModel>? playersColor = null;
		public static List<IPlayerColorModel>? PlayersColor
		{
			get
			{
				if (playersColor is null)
				{
					PlayersColor = new List<PlayerColorModel>();
				}
				return playersColor;
			}
			private set
			{
				playersColor = value;
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

		private Color color;
		public Color Color
		{
			get
			{
				return color;
			}
			set
			{
				color = value;
			}
		}
		#endregion

		#region .ctor
		public PlayerColorModel(CCSPlayerController player, Color color)
		{
			Player = player;
			PlayerPawn = player.PlayerPawn.Value;
			Color = color;

		}
		#endregion

		public void ApplyColoring()
		{
			playerPawn.Render = Color.FromArgb(255, color);
			Utilities.SetStateChanged(playerPawn, "CBaseModelEntity", "m_clrRender");
		}

		public void ClearColor()
		{
			playerPawn.Render = Color.FromArgb(255, 255, 255, 255);
			Utilities.SetStateChanged(playerPawn, "CBaseModelEntity", "m_clrRender");
		}

		public void ClearColorAndRemove()
		{
			playerPawn.Render = Color.FromArgb(255, 255, 255, 255);
			Utilities.SetStateChanged(playerPawn, "CBaseModelEntity", "m_clrRender");
			playersColor.Remove(this);
		}
	}
}
