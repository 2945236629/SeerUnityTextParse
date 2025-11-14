using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x0200204F RID: 8271
	public class IBranchItem
	{
		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x0600F836 RID: 63542 RVA: 0x0040E21F File Offset: 0x0040C41F
		// (set) Token: 0x0600F837 RID: 63543 RVA: 0x0040E227 File Offset: 0x0040C427
		public string intro { get; set; }

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x0600F838 RID: 63544 RVA: 0x0040E230 File Offset: 0x0040C430
		// (set) Token: 0x0600F839 RID: 63545 RVA: 0x0040E238 File Offset: 0x0040C438
		public IPlaceItem[] place { get; set; }

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x0600F83A RID: 63546 RVA: 0x0040E241 File Offset: 0x0040C441
		// (set) Token: 0x0600F83B RID: 63547 RVA: 0x0040E249 File Offset: 0x0040C449
		public string title { get; set; }

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x0600F83C RID: 63548 RVA: 0x0040E252 File Offset: 0x0040C452
		// (set) Token: 0x0600F83D RID: 63549 RVA: 0x0040E25A File Offset: 0x0040C45A
		public int ID { get; set; }

		// Token: 0x0600F83E RID: 63550 RVA: 0x0040E264 File Offset: 0x0040C464
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.place = new IPlaceItem[num];
				for (int i = 0; i < num; i++)
				{
					this.place[i] = new IPlaceItem();
					this.place[i].Parse(bytes, ref byteIndex);
				}
			}
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
