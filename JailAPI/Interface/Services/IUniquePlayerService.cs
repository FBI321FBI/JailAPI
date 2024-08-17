using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;

namespace JailAPI.Interface.Services
{
	public interface IUniquePlayerService
	{
		/// <summary>
		/// Создание уникального игрока.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="name">Имя уникального игрока. Например "Leading".</param>
		public void CreateUniquePlayer(CCSPlayerController player, string name, string? description = null);

		/// <summary>
		/// Получить уникального игрока по Player.
		/// </summary>
		/// <param name="name"></param>
		public IUniquePlayerModel GetUniquePlayer(CCSPlayerController player);

		/// <summary>
		/// Получить уникального игрока по ключу.
		/// </summary>
		/// <param name="name"></param>
		public IUniquePlayerModel GetUniquePlayer(string name);

		/// <summary>
		/// Удаляет уникального игрока по ключу.
		/// </summary>
		/// <param name="name">Ключ уникального игрока, которое вы дали. Например "Leading".</param>
		public void DeleteUniquePlayer(string name);

		/// <summary>
		/// Удаляет уникального игрока по модели.
		/// </summary>
		/// <param name="uniquePlayer">Модель уникального игрока.</param>
		public void DeleteUniquePlayer(IUniquePlayerModel uniquePlayer);
	}
}
