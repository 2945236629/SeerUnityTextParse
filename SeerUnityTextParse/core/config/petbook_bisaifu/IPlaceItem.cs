using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002055 RID: 8277
	public class IPlaceItem
	{
		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x0600F864 RID: 63588 RVA: 0x0040E5E4 File Offset: 0x0040C7E4
		// (set) Token: 0x0600F865 RID: 63589 RVA: 0x0040E5EC File Offset: 0x0040C7EC
		public string Desc { get; set; }

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x0600F866 RID: 63590 RVA: 0x0040E5F5 File Offset: 0x0040C7F5
		// (set) Token: 0x0600F867 RID: 63591 RVA: 0x0040E5FD File Offset: 0x0040C7FD
		public string Go { get; set; }

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x0600F868 RID: 63592 RVA: 0x0040E606 File Offset: 0x0040C806
		// (set) Token: 0x0600F869 RID: 63593 RVA: 0x0040E60E File Offset: 0x0040C80E
		public string Redirect { get; set; }

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x0600F86A RID: 63594 RVA: 0x0040E617 File Offset: 0x0040C817
		// (set) Token: 0x0600F86B RID: 63595 RVA: 0x0040E61F File Offset: 0x0040C81F
		public int[] Mintmark { get; set; }

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600F86C RID: 63596 RVA: 0x0040E628 File Offset: 0x0040C828
		// (set) Token: 0x0600F86D RID: 63597 RVA: 0x0040E630 File Offset: 0x0040C830
		public int ID { get; set; }

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x0600F86E RID: 63598 RVA: 0x0040E639 File Offset: 0x0040C839
		// (set) Token: 0x0600F86F RID: 63599 RVA: 0x0040E641 File Offset: 0x0040C841
		public int ImageID { get; set; }

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x0600F870 RID: 63600 RVA: 0x0040E64A File Offset: 0x0040C84A
		// (set) Token: 0x0600F871 RID: 63601 RVA: 0x0040E652 File Offset: 0x0040C852
		public int Label { get; set; }

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x0600F872 RID: 63602 RVA: 0x0040E65B File Offset: 0x0040C85B
		// (set) Token: 0x0600F873 RID: 63603 RVA: 0x0040E663 File Offset: 0x0040C863
		public int monID { get; set; }

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x0600F874 RID: 63604 RVA: 0x0040E66C File Offset: 0x0040C86C
		// (set) Token: 0x0600F875 RID: 63605 RVA: 0x0040E674 File Offset: 0x0040C874
		public int type { get; set; }

		// Token: 0x0600F876 RID: 63606 RVA: 0x0040E680 File Offset: 0x0040C880
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ImageID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Mintmark = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.Mintmark[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.Redirect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
