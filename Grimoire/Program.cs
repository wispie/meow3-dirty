using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Grimoire.Networking;
using Grimoire.UI;

namespace Grimoire
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000087FC File Offset: 0x000069FC
		[STAThread]
		private static void Main()
		{
			int listenerPort;
			if (Program.FindAvailablePort(out listenerPort))
			{
				Proxy.Instance.ListenerPort = listenerPort;
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Root());
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00008834 File Offset: 0x00006A34
		private static bool FindAvailablePort(out int port)
		{
			Random random = new Random();
			IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			TcpConnectionInformation[] activeTcpConnections;
			IPEndPoint[] activeTcpListeners;
			try
			{
				activeTcpConnections = ipglobalProperties.GetActiveTcpConnections();
				activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
			}
			catch (NetworkInformationException)
			{
				port = 0;
				return false;
			}
			int randPort;
			TcpConnectionInformation tcpConnectionInformation;
			IPEndPoint ipendPoint;
			do
			{
				randPort = random.Next(1001, 65535);
				tcpConnectionInformation = activeTcpConnections.FirstOrDefault((TcpConnectionInformation c) => c.LocalEndPoint.Port == randPort);
				ipendPoint = activeTcpListeners.FirstOrDefault((IPEndPoint l) => l.Port == randPort);
			}
			while (tcpConnectionInformation != null || ipendPoint != null);
			port = randPort;
			return true;
		}
	}
}
