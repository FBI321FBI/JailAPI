﻿using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Drawing;

namespace JailAPI.Model
{
	public class RiotPlayerModel : IRiotPlayerModel
	{
		#region Prop
		private static List<IRiotPlayerModel>? riotPlayers = null;
		public static List<IRiotPlayerModel>? RiotPlayers
		{
			get
			{
				if (riotPlayers is null)
				{
					RiotPlayers = new List<IRiotPlayerModel>();
				}
				return riotPlayers;
			}
			private set
			{
				riotPlayers = value;
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
        public RiotPlayerModel(CCSPlayerController player, Color color)
        {
			Player = player;
			PlayerPawn = player.PlayerPawn.Value;
			Color = color;
		}
        #endregion

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
			riotPlayers.Remove(this);
		}

		public void RefreshColorAndApply(Color color)
		{
			playerPawn.Render = Color.FromArgb(255, color);
			Utilities.SetStateChanged(playerPawn, "CBaseModelEntity", "m_clrRender");
		}
		#endregion
	}
}
