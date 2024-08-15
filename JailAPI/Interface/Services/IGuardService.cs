﻿using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using System.Collections.Concurrent;

namespace JailAPI.Interface.Services
{
	public interface IGuardService
	{
		/// <summary>
		/// Создание охранника.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="name">Имя охранника. Например "Warden".</param>
		public void CreateGuard(CCSPlayerController player, string name);

		/// <summary>
		/// Получить охранника по Player.
		/// </summary>
		/// <param name="name"></param>
		public IGuardModel GetGuard(CCSPlayerController player);

		/// <summary>
		/// Получить охранника по ключу.
		/// </summary>
		/// <param name="name"></param>
		public IGuardModel GetGuard(string name);

		/// <summary>
		/// Получить охранника по значению.
		/// </summary>
		/// <param name="name"></param>
		public KeyValuePair<string, IGuardModel>? GetGuard(IGuardModel guard);

		/// <summary>
		/// Удаляет охранника.
		/// </summary>
		/// <param name="name">Имя охранника, которое вы дали. Например "Warden".</param>
		public void DeleteGuard(string name);

		/// <summary>
		/// Удаляет охранника.
		/// </summary>
		/// <param name="guard">Охранник.</param>
		public void DeleteGuard(IGuardModel guard);
	}
}
