using JailAPI.Interface.Services;
using JailAPI.Services;

namespace JailAPI
{
	public class JailApi
	{
		#region Services
		public static IGuardService GuardService => new GuardService();
		#endregion
	}
}
