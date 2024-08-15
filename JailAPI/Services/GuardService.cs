using CounterStrikeSharp.API.Core;
using JailAPI.Interface.Model;
using JailAPI.Interface.Services;
using JailAPI.Model;

namespace JailAPI.Services
{
	public class GuardService : IGuardService
	{
		public void CreateGuard(CCSPlayerController player, string name)
		{
			GuardModel guard = new GuardModel(player);
			GuardModel.Guards.TryAdd(name, guard);
		}

		public IGuardModel? GetGuard(CCSPlayerController player)
		{
			foreach (var guard in GuardModel.Guards)
			{
				if (guard.Value.Player == player)
				{
					return guard.Value;
				}
			}
			return null;
		}

		public IGuardModel? GetGuard(string name)
		{
			if (GuardModel.Guards.TryGetValue(name, out var guard))
			{
				return guard;
			}
			else
			{
				return null;
			}
		}

		public KeyValuePair<string, IGuardModel>? GetGuard(IGuardModel guard)
		{
			foreach (var _guard in GuardModel.Guards)
			{
				if (_guard.Value == guard)
				{
					return _guard;
				}
			}
			return null;
		}

		public void DeleteGuard(string name)
		{
			var item = GuardModel.Guards[name];
			if (item is not null)
			{
				GuardModel.Guards.TryRemove(GetGuard(item).Value);
			}
			else
			{
				Console.WriteLine("[JailAPI] Удаление GUARD не удалось item => null. GuardService.DeleteGuard");
			}

		}

		public void DeleteGuard(IGuardModel guard)
		{
			var item = GetGuard(guard);
			if (!GuardModel.Guards.TryRemove(item.Value))
			{
				Console.WriteLine("[JailAPI] Охранник не был удалён. GuardService.DeleteGuard");
			}
		}
	}
}
