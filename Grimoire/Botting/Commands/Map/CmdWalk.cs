using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Map
{
	// Token: 0x02000174 RID: 372
	public class CmdWalk : IBotCommand
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00007DF1 File Offset: 0x00005FF1
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00007DF9 File Offset: 0x00005FF9
		public string X { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00007E02 File Offset: 0x00006002
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00007E0A File Offset: 0x0000600A
		public string Y { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00007E13 File Offset: 0x00006013
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00007E1B File Offset: 0x0000601B
		public string Type { get; set; }

		// Token: 0x0600094A RID: 2378 RVA: 0x00032B9C File Offset: 0x00030D9C
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			if (this.Type == "Random")
			{
				string y = new Random().Next(320, 450).ToString();
				Player.WalkToPoint(new Random().Next(150, 700).ToString(), y);
				await Task.Delay(1000);
			}
			else
			{
				Player.WalkToPoint(this.X, this.Y);
				await instance.WaitUntil(delegate
				{
					float[] position = Player.Position;
					return position[0].ToString() == this.X && position[1].ToString() == this.Y;
				}, null, 15);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00007E24 File Offset: 0x00006024
		public override string ToString()
		{
			if (this.Type == "Random")
			{
				return "Walk Randomly";
			}
			return "Walk to: " + this.X + ", " + this.Y;
		}
	}
}
