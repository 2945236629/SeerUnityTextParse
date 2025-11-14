using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002059 RID: 8281
	public class ITypeItem
	{
		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x0600F88C RID: 63628 RVA: 0x0040E914 File Offset: 0x0040CB14
		// (set) Token: 0x0600F88D RID: 63629 RVA: 0x0040E91C File Offset: 0x0040CB1C
		public IBranchItem[] Branch { get; set; }

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x0600F88E RID: 63630 RVA: 0x0040E925 File Offset: 0x0040CB25
		// (set) Token: 0x0600F88F RID: 63631 RVA: 0x0040E92D File Offset: 0x0040CB2D
		public int ID { get; set; }

		// Token: 0x0600F890 RID: 63632 RVA: 0x0040E938 File Offset: 0x0040CB38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Branch = new IBranchItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Branch[i] = new IBranchItem();
					this.Branch[i].Parse(bytes, ref byteIndex);
				}
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
