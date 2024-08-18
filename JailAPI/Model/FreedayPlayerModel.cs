using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Drawing;

namespace JailAPI.Model
{
	public class FreedayPlayerModel : IFreedayPlayerModel
	{
		#region Prop

		private static List<IFreedayPlayerModel>? freedayPlayers = null;

		public static List<IFreedayPlayerModel>? FreedayPlayers
		{
			get
			{
				if (freedayPlayers is null)
				{
					FreedayPlayers = new List<IFreedayPlayerModel>();
				}
				return freedayPlayers;
			}
			private set
			{
				freedayPlayers = value;
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

		#endregion Prop

		#region .ctor

		public FreedayPlayerModel(CCSPlayerController player, Color color)
		{
			Player = player;
			PlayerPawn = player.PlayerPawn.Value;
			Color = color;
		}

		#endregion .ctor

		#region Public

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
			freedayPlayers.Remove(this);
		}

		public void RefreshColorAndApply(Color color)
		{
			playerPawn.Render = Color.FromArgb(255, color);
			Utilities.SetStateChanged(playerPawn, "CBaseModelEntity", "m_clrRender");
		}

		#endregion Public
	}
}