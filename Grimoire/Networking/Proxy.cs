using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Grimoire.Game;
using Grimoire.Networking.Handlers;
using Grimoire.Tools;

namespace Grimoire.Networking
{
	// Token: 0x0200008C RID: 140
	public class Proxy
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00004311 File Offset: 0x00002511
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00004318 File Offset: 0x00002518
		public static Proxy Instance { get; set; } = new Proxy();

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00004320 File Offset: 0x00002520
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00004328 File Offset: 0x00002528
		public int ListenerPort { get; set; }

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000373 RID: 883 RVA: 0x00029980 File Offset: 0x00027B80
		// (remove) Token: 0x06000374 RID: 884 RVA: 0x000299B8 File Offset: 0x00027BB8
		public event Proxy.Receive ReceivedFromClient;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000375 RID: 885 RVA: 0x000299F0 File Offset: 0x00027BF0
		// (remove) Token: 0x06000376 RID: 886 RVA: 0x00029A28 File Offset: 0x00027C28
		public event Proxy.Receive ReceivedFromServer;

		// Token: 0x06000377 RID: 887 RVA: 0x00029A60 File Offset: 0x00027C60
		private Proxy()
		{
			this._handlersJson = new List<IJsonMessageHandler>
			{
				new HandlerSkills(),
				new HandlerDropItem(),
				new HandlerGetQuests(),
				new HandlerQuestComplete(),
				new HandlerLoadShop()
			};
			this._handlersXt = new List<IXtMessageHandler>
			{
				new HandlerWarningsXt(),
				new HandlerLogin(),
				new HandlerChat(),
				new HandlerXtJoin()
			};
			this._handlersXml = new List<IXmlMessageHandler>
			{
				new HandlerPolicy(),
				new HandlerWarningsXml()
			};
			this._shouldConnect = true;
			this.ReceivedFromServer += this.ProcessMessage;
			this.ReceivedFromClient += this.ProcessMessage;
			this._bufferClient = new List<byte>();
			this._bufferServer = new List<byte>();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00004331 File Offset: 0x00002531
		public void RegisterHandler(IJsonMessageHandler handler)
		{
			this.RegisterHandler<IJsonMessageHandler>(handler, this._handlersJson);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00004340 File Offset: 0x00002540
		public void RegisterHandler(IXmlMessageHandler handler)
		{
			this.RegisterHandler<IXmlMessageHandler>(handler, this._handlersXml);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000434F File Offset: 0x0000254F
		public void RegisterHandler(IXtMessageHandler handler)
		{
			this.RegisterHandler<IXtMessageHandler>(handler, this._handlersXt);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000435E File Offset: 0x0000255E
		public void UnregisterHandler(IJsonMessageHandler handler)
		{
			this._handlersJson.Remove(handler);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000436D File Offset: 0x0000256D
		public void UnregisterHandler(IXmlMessageHandler handler)
		{
			this._handlersXml.Remove(handler);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000437C File Offset: 0x0000257C
		public void UnregisterHandler(IXtMessageHandler handler)
		{
			this._handlersXt.Remove(handler);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000438B File Offset: 0x0000258B
		private void RegisterHandler<T>(T handler, List<T> list)
		{
			if (!list.Contains(handler))
			{
				list.Add(handler);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00029B50 File Offset: 0x00027D50
		public async Task Start()
		{
			if (this._listener == null)
			{
				this._listener = new TcpListener(IPAddress.Loopback, this.ListenerPort);
			}
			while (!Proxy.AppClosingToken.IsCancellationRequested)
			{
				if (this._shouldConnect)
				{
					try
					{
						await this.AcceptAndConnect();
						this._shouldConnect = false;
						continue;
					}
					catch
					{
						continue;
					}
				}
				await Task.Delay(1000);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00029B98 File Offset: 0x00027D98
		private async Task AcceptAndConnect()
		{
			this._listener.Start();
			TcpClient client = await this._listener.AcceptTcpClientAsync();
			this._client = client;
			this._server = new TcpClient();
			string text = Flash.Call<string>("RealAddress", new string[0]);
			IPAddress gameServerAddress;
			try
			{
				gameServerAddress = IPAddress.Parse(text);
			}
			catch (Exception)
			{
				gameServerAddress = Dns.GetHostEntry(text).AddressList[0];
			}
			if (this._policyReceived)
			{
				await this._server.ConnectAsync(gameServerAddress, Flash.Call<int>("RealPort", new string[0]));
			}
			else
			{
				byte[] cbuffer2 = new byte[1024];
				byte[] sbuffer2 = new byte[1024];
				byte[] buffer = cbuffer2;
				cbuffer2 = this.ReceiveOnce(buffer, await this._client.GetStream().ReadAsync(cbuffer2, 0, 1024));
				buffer = null;
				await this._server.ConnectAsync(gameServerAddress, Flash.Call<int>("RealPort", new string[0]));
				await this.SendToServer(cbuffer2);
				buffer = sbuffer2;
				sbuffer2 = this.ReceiveOnce(buffer, await this._server.GetStream().ReadAsync(sbuffer2, 0, 1024));
				buffer = null;
				await this.SendToClient(this.ModifyDomainPolicy(sbuffer2));
				this._client.Close();
				this._client = await this._listener.AcceptTcpClientAsync();
				this._policyReceived = true;
				cbuffer2 = null;
				sbuffer2 = null;
			}
			this._listener.Stop();
			Task.Factory.StartNew<Task>(new Func<Task>(this.ReceiveFromClient), TaskCreationOptions.LongRunning);
			Task.Factory.StartNew<Task>(new Func<Task>(this.ReceiveFromServer), TaskCreationOptions.LongRunning);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00029BE0 File Offset: 0x00027DE0
		private byte[] ModifyDomainPolicy(byte[] policy)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(Encoding.UTF8.GetString(policy));
			xmlDocument["cross-domain-policy"]["allow-access-from"].Attributes["to-ports"].Value = this.ListenerPort.ToString();
			return Encoding.UTF8.GetBytes(xmlDocument.OuterXml);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00029C4C File Offset: 0x00027E4C
		private byte[] ReceiveOnce(byte[] buffer, int read)
		{
			byte[] array = new byte[read];
			Array.Copy(buffer, array, read);
			return array;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00029C6C File Offset: 0x00027E6C
		public void Stop(bool appClosing)
		{
			if (!this._shouldConnect)
			{
				if (appClosing)
				{
					Proxy.AppClosingToken.Cancel();
				}
				TcpClient server = this._server;
				if (server != null)
				{
					server.Close();
				}
				TcpClient client = this._client;
				if (client != null)
				{
					client.Close();
				}
				this._listener.Stop();
				this._shouldConnect = true;
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00029CC4 File Offset: 0x00027EC4
		private async Task ReceiveFromClient()
		{
			while (!Proxy.AppClosingToken.IsCancellationRequested)
			{
				try
				{
					NetworkStream stream = this._client.GetStream();
					if (!this._shouldConnect && stream.CanRead)
					{
						byte[] buffer = new byte[1024];
						int num = await stream.ReadAsync(buffer, 0, 1024);
						int read;
						if ((read = num) == 0)
						{
							this.Stop(false);
							break;
						}
						int i = 0;
						while (--read >= 0)
						{
							byte b = buffer[i++];
							if (b != 0)
							{
								this._bufferClient.Add(b);
							}
							else
							{
								byte[] bytes = this._bufferClient.ToArray();
								Message message = this.CreateMessage(Encoding.UTF8.GetString(bytes));
								Proxy.Receive receivedFromClient = this.ReceivedFromClient;
								if (receivedFromClient != null)
								{
									receivedFromClient(message);
								}
								if (message.Send)
								{
									await this.SendToServer(message.ToString());
								}
								this._bufferClient = new List<byte>();
							}
						}
						buffer = null;
					}
				}
				catch
				{
					this.Stop(false);
					break;
				}
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00029D0C File Offset: 0x00027F0C
		private async Task ReceiveFromServer()
		{
			while (!Proxy.AppClosingToken.IsCancellationRequested)
			{
				try
				{
					NetworkStream stream = this._server.GetStream();
					if (!this._shouldConnect && stream.CanRead)
					{
						byte[] buffer = new byte[1024];
						int num = await stream.ReadAsync(buffer, 0, 1024);
						int read;
						if ((read = num) == 0)
						{
							this.Stop(false);
							break;
						}
						int i = 0;
						while (--read >= 0)
						{
							byte b = buffer[i++];
							if (b != 0)
							{
								this._bufferServer.Add(b);
							}
							else
							{
								byte[] bytes = this._bufferServer.ToArray();
								Message message = this.CreateMessage(Encoding.UTF8.GetString(bytes));
								Proxy.Receive receivedFromServer = this.ReceivedFromServer;
								if (receivedFromServer != null)
								{
									receivedFromServer(message);
								}
								if (message.Send)
								{
									await this.SendToClient(message.ToString());
								}
								this._bufferServer = new List<byte>();
							}
						}
						buffer = null;
					}
				}
				catch
				{
					this.Stop(false);
					break;
				}
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00029D54 File Offset: 0x00027F54
		public async Task SendToServer(string data)
		{
			string text = data.Replace("{ROOM_ID}", World.RoomId.ToString());
			if (text != null && text.Length > 0)
			{
				if (text[text.Length - 1] != '\0')
				{
					text += "\0";
				}
				await this.SendToServer(Encoding.UTF8.GetBytes(text));
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00029DA4 File Offset: 0x00027FA4
		public async Task SendToServer(byte[] data)
		{
			NetworkStream stream = this._server.GetStream();
			if (stream.CanWrite)
			{
				try
				{
					await stream.WriteAsync(data, 0, data.Length);
				}
				catch
				{
					this.Stop(false);
				}
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00029DF4 File Offset: 0x00027FF4
		public async Task SendToClient(string data)
		{
			string text = data;
			if (text != null && text.Length > 0)
			{
				if (data[data.Length - 1] != '\0')
				{
					data += "\0";
				}
				await this.SendToClient(Encoding.UTF8.GetBytes(data));
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00029E44 File Offset: 0x00028044
		public async Task SendToClient(byte[] data)
		{
			NetworkStream stream = this._client.GetStream();
			if (stream.CanWrite)
			{
				try
				{
					await stream.WriteAsync(data, 0, data.Length);
				}
				catch
				{
					this.Stop(false);
				}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00029E94 File Offset: 0x00028094
		private void ProcessMessage(Message message)
		{
			try
			{
				if (message != null)
				{
					XtMessage <xtMessage>5__;
					JsonMessage <jsonMessage>5__;
					XmlMessage <xmlMessage>5__;
					if ((<xtMessage>5__ = (message as XtMessage)) == null)
					{
						if ((<jsonMessage>5__ = (message as JsonMessage)) == null)
						{
							if ((<xmlMessage>5__ = (message as XmlMessage)) != null)
							{
								goto IL_10A;
							}
							goto IL_174;
						}
					}
					else
					{
						XtMessage <xtMessage>5__2 = <xtMessage>5__;
						IEnumerable<IXtMessageHandler> handlersXt = this._handlersXt;
						Func<IXtMessageHandler, bool> predicate;
						Func<IXtMessageHandler, bool> <>9__0;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((IXtMessageHandler h) => h.HandledCommands.Contains(<xtMessage>5__2.Command)));
						}
						using (IEnumerator<IXtMessageHandler> enumerator = handlersXt.Where(predicate).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								IXtMessageHandler xtMessageHandler = enumerator.Current;
								xtMessageHandler.Handle(<xtMessage>5__2);
							}
							goto IL_174;
						}
					}
					JsonMessage <jsonMessage>5__3 = <jsonMessage>5__;
					IEnumerable<IJsonMessageHandler> handlersJson = this._handlersJson;
					Func<IJsonMessageHandler, bool> predicate2;
					Func<IJsonMessageHandler, bool> <>9__1;
					if ((predicate2 = <>9__1) == null)
					{
						predicate2 = (<>9__1 = ((IJsonMessageHandler h) => h.HandledCommands.Contains(<jsonMessage>5__3.Command)));
					}
					using (IEnumerator<IJsonMessageHandler> enumerator2 = handlersJson.Where(predicate2).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							IJsonMessageHandler jsonMessageHandler = enumerator2.Current;
							jsonMessageHandler.Handle(<jsonMessage>5__3);
						}
						goto IL_174;
					}
					IL_10A:
					XmlMessage <xmlMessage>5__4 = <xmlMessage>5__;
					IEnumerable<IXmlMessageHandler> handlersXml = this._handlersXml;
					Func<IXmlMessageHandler, bool> predicate3;
					Func<IXmlMessageHandler, bool> <>9__2;
					if ((predicate3 = <>9__2) == null)
					{
						predicate3 = (<>9__2 = ((IXmlMessageHandler h) => h.HandledCommands.Contains(<xmlMessage>5__4.Command)));
					}
					foreach (IXmlMessageHandler xmlMessageHandler in handlersXml.Where(predicate3))
					{
						xmlMessageHandler.Handle(<xmlMessage>5__4);
					}
				}
				IL_174:;
			}
			catch
			{
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0002A080 File Offset: 0x00028280
		private Message CreateMessage(string raw)
		{
			if (raw != null && raw.Length > 0)
			{
				char c = raw[0];
				if (c == '%')
				{
					return new XtMessage(raw);
				}
				if (c == '<')
				{
					return new XmlMessage(raw);
				}
				if (c == '{')
				{
					return new JsonMessage(raw);
				}
			}
			return null;
		}

		// Token: 0x0400030F RID: 783
		private readonly List<IJsonMessageHandler> _handlersJson;

		// Token: 0x04000310 RID: 784
		private readonly List<IXtMessageHandler> _handlersXt;

		// Token: 0x04000311 RID: 785
		private readonly List<IXmlMessageHandler> _handlersXml;

		// Token: 0x04000312 RID: 786
		private TcpClient _client;

		// Token: 0x04000313 RID: 787
		private TcpClient _server;

		// Token: 0x04000314 RID: 788
		private TcpListener _listener;

		// Token: 0x04000315 RID: 789
		private List<byte> _bufferClient;

		// Token: 0x04000316 RID: 790
		private List<byte> _bufferServer;

		// Token: 0x04000317 RID: 791
		private const int MaxBufferSize = 1024;

		// Token: 0x04000318 RID: 792
		private static readonly CancellationTokenSource AppClosingToken = new CancellationTokenSource();

		// Token: 0x04000319 RID: 793
		private bool _shouldConnect;

		// Token: 0x0400031A RID: 794
		private bool _policyReceived;

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600038E RID: 910
		public delegate void Receive(Message message);
	}
}
