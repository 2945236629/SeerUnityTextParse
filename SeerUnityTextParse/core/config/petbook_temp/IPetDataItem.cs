using System;

namespace core.config.petbook_temp
{
	// Token: 0x02002049 RID: 8265
	public class IPetDataItem : IConfigItem
	{
		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x0600F7FE RID: 63486 RVA: 0x0040DDAA File Offset: 0x0040BFAA
		// (set) Token: 0x0600F7FF RID: 63487 RVA: 0x0040DDB2 File Offset: 0x0040BFB2
		public int[] TagB { get; set; }

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x0600F800 RID: 63488 RVA: 0x0040DDBB File Offset: 0x0040BFBB
		// (set) Token: 0x0600F801 RID: 63489 RVA: 0x0040DDC3 File Offset: 0x0040BFC3
		public int id { get; set; }

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x0600F802 RID: 63490 RVA: 0x0040DDCC File Offset: 0x0040BFCC
		// (set) Token: 0x0600F803 RID: 63491 RVA: 0x0040DDD4 File Offset: 0x0040BFD4
		public int pid { get; set; }

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600F804 RID: 63492 RVA: 0x0040DDDD File Offset: 0x0040BFDD
		// (set) Token: 0x0600F805 RID: 63493 RVA: 0x0040DDE5 File Offset: 0x0040BFE5
		public int TagA { get; set; }

		// Token: 0x0600F806 RID: 63494 RVA: 0x0040DDF0 File Offset: 0x0040BFF0
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
