﻿using CounterStrikeSharp.API.Core;
using System.Drawing;

namespace JailAPI.Interface.Model
{
	public interface IRiotPlayerModel
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
		/// Цвет.
		/// </summary>
		public Color Color { get; }

		/// <summary>
		/// Окрасить игрока.
		/// </summary>
		public void ApplyColoring();

		/// <summary>
		/// Убрать окраску игрока.
		/// </summary>
		public void ClearColor();

		/// <summary>
		/// Убрать окраску игрока. И удалить его из RiotPlayers.
		/// </summary>
		public void ClearColorAndRemove();

		/// <summary>
		/// Обновить цвет игрока и применить.
		/// </summary>
		/// <param name="color"></param>
		public void RefreshColorAndApply(Color color);
	}
}
