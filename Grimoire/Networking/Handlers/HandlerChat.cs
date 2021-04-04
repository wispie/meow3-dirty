using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using Grimoire.Botting;
using Grimoire.Game;
using Grimoire.UI;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x0200009F RID: 159
	public class HandlerChat : IXtMessageHandler
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00004621 File Offset: 0x00002821
		public string[] HandledCommands { get; } = new string[]
		{
			"chatm",
			"warning",
			"whisper",
			"message"
		};

		// Token: 0x060003BF RID: 959 RVA: 0x0002B274 File Offset: 0x00029474
		public void Handle(XtMessage message)
		{
			if (message.Arguments[2] == "zm" && message.Arguments[5].StartsWith("."))
			{
				string text = "-";
				string key = message.Arguments[5];
				string[] texts;
				try
				{
					texts = message.Arguments[5].Split(new char[]
					{
						' '
					});
				}
				catch
				{
					texts = new string[0];
				}
				if (this.chatcommands.ContainsKey(key) || this.chatcommands.ContainsKey(texts[0]))
				{
					string[] array = this.chatcommands[key].Split(new char[]
					{
						','
					});
					string text2 = array[1];
					text2 = new Regex("{arg(.)}", RegexOptions.IgnoreCase).Replace(text2, (Match m) => texts[1].Replace("#037:", "%"));
					if (array[0] == "Client")
					{
						Proxy.Instance.SendToClient(text2);
					}
					else
					{
						Proxy.Instance.SendToServer(text2);
					}
					MessageBox.Show(text2);
				}
				else if (this.tercesstravels.ContainsKey(key))
				{
					try
					{
						text += message.Arguments[5].Split(new char[]
						{
							'-'
						})[1];
						text = (text.Split(new char[]
						{
							'-'
						})[1].Contains("e") ? "-100000" : text);
						key = message.Arguments[5].Split(new char[]
						{
							'-'
						})[0];
					}
					catch
					{
						text += "1";
					}
					if (Player.Map.ToLower() != "citadel")
					{
						Player.ExecuteTravel(new List<IBotCommand>
						{
							Player.CreateJoinCommand("citadel-100000", "m22", "Left")
						});
					}
					Player.ExecuteTravel(new List<IBotCommand>
					{
						Player.CreateJoinCommand("tercessuinotlim" + text, this.tercesstravels[key].Split(new char[]
						{
							','
						})[0], this.tercesstravels[key].Split(new char[]
						{
							','
						})[1])
					});
				}
				message.Send = false;
			}
			string a = message.Arguments[2];
			string text3 = message.Arguments[4];
			message.Arguments[5] = ((message.Arguments[5] == Player.Username && OptionsManager.ChangeChat) ? "You" : message.Arguments[5]);
			if (!(a == "chatm"))
			{
				if (a == "whisper")
				{
					text3 = ((message.Arguments[6] == Player.Username) ? ("From " + message.Arguments[5]) : ("To " + message.Arguments[6]));
					text3 = text3 + ": " + message.Arguments[4];
				}
			}
			else
			{
				text3 = (message.Arguments[5] + message.Arguments[4]).Replace("zone~", ": ");
			}
			LogForm.Instance.AppendChat(string.Format("[{0:hh:mm:ss}] {1} \r\n", DateTime.Now, text3));
		}

		// Token: 0x04000360 RID: 864
		private Dictionary<string, string> tercesstravels = new Dictionary<string, string>
		{
			{
				".oblivion",
				"Enter,     Spawn"
			},
			{
				".twins",
				"Twins,     Left"
			},
			{
				".swindle",
				"Swindle,   Left"
			},
			{
				".nulgath",
				"Boss2,     Right"
			},
			{
				".carnage",
				"m4,        Top"
			},
			{
				".lae",
				"m5,        Top"
			},
			{
				".polish",
				"m12,       Top"
			}
		};

		// Token: 0x04000361 RID: 865
		private Dictionary<string, string> chatcommands = new Dictionary<string, string>
		{
			{
				".pvp",
				string.Format("Server, %xt%zm%PVPQr%{0}%doomarena%", Player.UserID)
			},
			{
				".server",
				"Server, {arg5}"
			},
			{
				".client",
				"Client, {arg5}"
			}
		};
	}
}
