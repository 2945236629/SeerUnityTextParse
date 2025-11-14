using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002054 RID: 8276
	public class IPetDataItem : IConfigItem
	{
		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x0600F85A RID: 63578 RVA: 0x0040E52A File Offset: 0x0040C72A
		// (set) Token: 0x0600F85B RID: 63579 RVA: 0x0040E532 File Offset: 0x0040C732
		public int[] TagB { get; set; }

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x0600F85C RID: 63580 RVA: 0x0040E53B File Offset: 0x0040C73B
		// (set) Token: 0x0600F85D RID: 63581 RVA: 0x0040E543 File Offset: 0x0040C743
		public int id { get; set; }

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x0600F85E RID: 63582 RVA: 0x0040E54C File Offset: 0x0040C74C
		// (set) Token: 0x0600F85F RID: 63583 RVA: 0x0040E554 File Offset: 0x0040C754
		public int pid { get; set; }

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x0600F860 RID: 63584 RVA: 0x0040E55D File Offset: 0x0040C75D
		// (set) Token: 0x0600F861 RID: 63585 RVA: 0x0040E565 File Offset: 0x0040C765
		public int TagA { get; set; }

		// Token: 0x0600F862 RID: 63586 RVA: 0x0040E570 File Offset: 0x0040C770
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.TagA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TagB = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.TagB[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
