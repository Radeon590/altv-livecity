// Licensed to b2soft under the MIT license

using AltV.Net.Client;
using LiveCity.Shared;

namespace LiveCity.Client.Resource
{
	public class LoggingTestService : ILiveCityService
	{
		public void Log(string message)
		{
			Alt.LogInfo(message);
		}
	}
}
