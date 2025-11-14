using System;

namespace core.config.petbook
{
	// Token: 0x0200205F RID: 8287
	public class IPetDataItem : IConfigItem
	{
		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x0600F8B6 RID: 63670 RVA: 0x0040ECAA File Offset: 0x0040CEAA
		// (set) Token: 0x0600F8B7 RID: 63671 RVA: 0x0040ECB2 File Offset: 0x0040CEB2
		public int[] TagB { get; set; }

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600F8B8 RID: 63672 RVA: 0x0040ECBB File Offset: 0x0040CEBB
		// (set) Token: 0x0600F8B9 RID: 63673 RVA: 0x0040ECC3 File Offset: 0x0040CEC3
		public int id { get; set; }

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600F8BA RID: 63674 RVA: 0x0040ECCC File Offset: 0x0040CECC
		// (set) Token: 0x0600F8BB RID: 63675 RVA: 0x0040ECD4 File Offset: 0x0040CED4
		public int pid { get; set; }

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600F8BC RID: 63676 RVA: 0x0040ECDD File Offset: 0x0040CEDD
		// (set) Token: 0x0600F8BD RID: 63677 RVA: 0x0040ECE5 File Offset: 0x0040CEE5
		public int TagA { get; set; }

		// Token: 0x0600F8BE RID: 63678 RVA: 0x0040ECF0 File Offset: 0x0040CEF0
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
