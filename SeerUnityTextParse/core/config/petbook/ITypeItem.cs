using System;

namespace core.config.petbook
{
	// Token: 0x02002064 RID: 8292
	public class ITypeItem
	{
		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x0600F8E8 RID: 63720 RVA: 0x0040F094 File Offset: 0x0040D294
		// (set) Token: 0x0600F8E9 RID: 63721 RVA: 0x0040F09C File Offset: 0x0040D29C
		public IBranchItem[] Branch { get; set; }

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x0600F8EA RID: 63722 RVA: 0x0040F0A5 File Offset: 0x0040D2A5
		// (set) Token: 0x0600F8EB RID: 63723 RVA: 0x0040F0AD File Offset: 0x0040D2AD
		public int ID { get; set; }

		// Token: 0x0600F8EC RID: 63724 RVA: 0x0040F0B8 File Offset: 0x0040D2B8
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
