using System;
using System.Threading.Tasks;

namespace Grimoire.Botting
{
	// Token: 0x020000FC RID: 252
	public interface IBotCommand
	{
		// Token: 0x06000756 RID: 1878
		Task Execute(IBotEngine instance);
	}
}
