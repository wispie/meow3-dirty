using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Map
{
	// Token: 0x02000176 RID: 374
	public class CmdYulgar : IBotCommand
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x00032DE8 File Offset: 0x00030FE8
		public async Task Execute(IBotEngine instance)
		{
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.Transfer), null, 15);
			if (Player.CurrentState == Player.State.InCombat)
			{
				Player.MoveToCell(Player.Cell, Player.Pad);
				await Task.Delay(1250);
			}
			if (!Player.Map.Equals("yulgar", StringComparison.OrdinalIgnoreCase))
			{
				Player.JoinMap("yulgar", "Enter", "Spawn");
				await instance.WaitUntil(() => Player.Map.Equals("yulgar", StringComparison.OrdinalIgnoreCase), null, 15);
				await instance.WaitUntil(() => !World.IsMapLoading, null, 40);
			}
			string y = new Random().Next(320, 450).ToString();
			Player.WalkToPoint(new Random().Next(150, 700).ToString(), y);
			instance.Stop();
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00007E67 File Offset: 0x00006067
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Join yulgar"
			});
		}
	}
}
