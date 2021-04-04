using System;
using System.Net;
using System.Net.Sockets;

namespace Grimoire.Utils
{
	// Token: 0x0200000A RID: 10
	public class NetworkUtils
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000089E4 File Offset: 0x00006BE4
		public static int GetAvailablePort()
		{
			int port;
			using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
			{
				socket.Bind(new IPEndPoint(IPAddress.Loopback, 0));
				port = ((IPEndPoint)socket.LocalEndPoint).Port;
			}
			return port;
		}
	}
}
