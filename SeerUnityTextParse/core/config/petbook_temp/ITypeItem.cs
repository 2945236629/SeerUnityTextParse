using System;

namespace core.config.petbook_temp
{
	// Token: 0x0200204E RID: 8270
	public class ITypeItem
	{
		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x0600F830 RID: 63536 RVA: 0x0040E194 File Offset: 0x0040C394
		// (set) Token: 0x0600F831 RID: 63537 RVA: 0x0040E19C File Offset: 0x0040C39C
		public IBranchItem[] Branch { get; set; }

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x0600F832 RID: 63538 RVA: 0x0040E1A5 File Offset: 0x0040C3A5
		// (set) Token: 0x0600F833 RID: 63539 RVA: 0x0040E1AD File Offset: 0x0040C3AD
		public int ID { get; set; }

		// Token: 0x0600F834 RID: 63540 RVA: 0x0040E1B8 File Offset: 0x0040C3B8
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
