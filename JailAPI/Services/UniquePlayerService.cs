using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Model;
using System.Xml.Linq;

namespace JailAPI.Services
{
	public class UniquePlayerService : IUniquePlayerService
	{
		#region Public
		public void CreateUniquePlayer(CCSPlayerController player, string name, string? description = null)
		{
			UniquePlayerModel uniquePlayer = new UniquePlayerModel(player);
			UniquePlayerModel.UniquePlayers.TryAdd(name, uniquePlayer);
		}

		public void DeleteUniquePlayer(string name)
		{
			var item = UniquePlayerModel.UniquePlayers[name];
			if (item is not null)
			{
				UniquePlayerModel.UniquePlayers.TryRemove(UniquePlayerModel.UniquePlayers.Where(x => x.Value == item).FirstOrDefault());
			}
			else
			{
				Console.WriteLine("[JailAPI] Удаление UniquePlayer не удалось item => null. UniquePlayerService.DeleteUniquePlayer");
			}
		}

		public void DeleteUniquePlayer(IUniquePlayerModel uniquePlayer)
		{
			var item = UniquePlayerModel.UniquePlayers.Where(x => x.Value == uniquePlayer).FirstOrDefault();
			
			if(!UniquePlayerModel.UniquePlayers.TryRemove(item))
			{
				Console.WriteLine("[JailAPI] Удаление UniquePlayer не удалось. UniquePlayerService.DeleteUniquePlayer");
			}
		}

		public IUniquePlayerModel? GetUniquePlayer(CCSPlayerController player)
		{
			foreach(var uniquePlayer in UniquePlayerModel.UniquePlayers)
			{
				if (uniquePlayer.Value.Player == player)
				{
					return uniquePlayer.Value;
				}
			}
			return null;
		}

		public IUniquePlayerModel? GetUniquePlayer(string name)
		{
			if (UniquePlayerModel.UniquePlayers.TryGetValue(name, out var uniquePlayer))
			{
				return uniquePlayer;
			}
			else
			{
				return null;
			}
		}
		#endregion
	}
}
