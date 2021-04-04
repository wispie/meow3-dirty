using System;
using System.Threading;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;

namespace Grimoire.Botting.Commands.Combat
{
	// Token: 0x0200019F RID: 415
	public class CmdKill : IBotCommand
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00008337 File Offset: 0x00006537
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x0000833F File Offset: 0x0000653F
		public string Monster { get; set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00008348 File Offset: 0x00006548
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00008350 File Offset: 0x00006550
		public bool Packet { get; set; }

		// Token: 0x060009EB RID: 2539 RVA: 0x00034C64 File Offset: 0x00032E64
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Combat;
			if (BotData.BotCell != null && !Player.Cell.Equals(BotData.BotCell, StringComparison.OrdinalIgnoreCase))
			{
				Player.MoveToCell(BotData.BotCell, BotData.BotPad);
				await Task.Delay(1000);
			}
			await instance.WaitUntil(() => World.IsMonsterAvailable(this.Monster), null, 3);
			if (instance.Configuration.WaitForAllSkills)
			{
				await Task.Delay(Player.AllSkillsAvailable);
			}
			if (instance.IsRunning && Player.IsAlive && Player.IsLoggedIn)
			{
				Player.AttackMonster(this.Monster);
				await Task.Delay(500);
				Task.Run(() => this.UseSkills(instance));
				await instance.WaitUntil(() => !Player.HasTarget, null, 360);
				CancellationTokenSource cts = this._cts;
				if (cts != null)
				{
					cts.Cancel(false);
				}
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00034CB4 File Offset: 0x00032EB4
		private async Task UseSkills(IBotEngine instance)
		{
			this._cts = new CancellationTokenSource();
			int ClassIndex = -1;
			if (BotData.SkillSet != null && BotData.SkillSet.ContainsKey("[" + BotData.BotSkill + "]"))
			{
				ClassIndex = BotData.SkillSet["[" + BotData.BotSkill + "]"] + 1;
			}
			int Count = instance.Configuration.Skills.Count - 1;
			this.Index = ClassIndex;
			while (!this._cts.IsCancellationRequested)
			{
				if (Player.IsLoggedIn)
				{
					if (Player.IsAlive)
					{
						if (this.Monster.ToLower() == "escherion" && World.IsMonsterAvailable("Staff of Inversion"))
						{
							Player.AttackMonster("Staff of Inversion");
						}
						else if (this.Monster.ToLower() == "vath" && World.IsMonsterAvailable("Stalagbite"))
						{
							Player.AttackMonster("Stalagbite");
						}
						if (ClassIndex != -1)
						{
							Skill s = instance.Configuration.Skills[this.Index];
							if (s.Type == Skill.SkillType.Label)
							{
								this.Index = ClassIndex;
								continue;
							}
							if (instance.Configuration.WaitForSkill)
							{
								BotManager.Instance.OnSkillIndexChanged(this.Index);
								await Task.Delay(Player.SkillAvailable(s.Index));
							}
							if (s.Type == Skill.SkillType.Safe)
							{
								if (s.SafeMp)
								{
									if ((double)Player.Mana / (double)Player.ManaMax * 100.0 <= (double)s.SafeHealth)
									{
										Player.UseSkill(s.Index);
									}
								}
								else if ((double)Player.Health / (double)Player.HealthMax * 100.0 <= (double)s.SafeHealth)
								{
									Player.UseSkill(s.Index);
								}
							}
							else
							{
								Player.UseSkill(s.Index);
							}
							int index;
							if (this.Index < Count)
							{
								int num = this.Index + 1;
								this.Index = num;
								index = num;
							}
							else
							{
								index = ClassIndex;
							}
							this.Index = index;
							s = null;
						}
						else
						{
							int[] array = new int[]
							{
								Player.SkillAvailable("1"),
								Player.SkillAvailable("2"),
								Player.SkillAvailable("3"),
								Player.SkillAvailable("4")
							};
							int num2 = array[0];
							int MinIndex = 1;
							for (int i = 1; i < 4; i++)
							{
								if (array[i] < num2)
								{
									num2 = array[i];
									MinIndex = i + 1;
								}
							}
							await Task.Delay(num2);
							Player.UseSkill(MinIndex.ToString());
						}
						await Task.Delay(instance.Configuration.SkillDelay);
						continue;
					}
				}
				while (Player.HasTarget)
				{
					Player.CancelTarget();
					await Task.Delay(500);
				}
				return;
			}
			while (Player.HasTarget)
			{
				Player.CancelTarget();
				await Task.Delay(500);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00008359 File Offset: 0x00006559
		public override string ToString()
		{
			return "Kill " + this.Monster;
		}

		// Token: 0x0400068B RID: 1675
		private CancellationTokenSource _cts;

		// Token: 0x0400068C RID: 1676
		private int Index;
	}
}
