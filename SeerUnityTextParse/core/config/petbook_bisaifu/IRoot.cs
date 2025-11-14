using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002057 RID: 8279
	public class IRoot
	{
		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x0600F87C RID: 63612 RVA: 0x0040E7B6 File Offset: 0x0040C9B6
		// (set) Token: 0x0600F87D RID: 63613 RVA: 0x0040E7BE File Offset: 0x0040C9BE
		public IHotPet HotPet { get; set; }

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x0600F87E RID: 63614 RVA: 0x0040E7C7 File Offset: 0x0040C9C7
		// (set) Token: 0x0600F87F RID: 63615 RVA: 0x0040E7CF File Offset: 0x0040C9CF
		public IHotspot Hotspot { get; set; }

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600F880 RID: 63616 RVA: 0x0040E7D8 File Offset: 0x0040C9D8
		// (set) Token: 0x0600F881 RID: 63617 RVA: 0x0040E7E0 File Offset: 0x0040C9E0
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x0600F882 RID: 63618 RVA: 0x0040E7E9 File Offset: 0x0040C9E9
		// (set) Token: 0x0600F883 RID: 63619 RVA: 0x0040E7F1 File Offset: 0x0040C9F1
		public IRecMintmark RecMintmark { get; set; }

		// Token: 0x0600F884 RID: 63620 RVA: 0x0040E7FC File Offset: 0x0040C9FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.HotPet = new IHotPet();
				this.HotPet.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Hotspot = new IHotspot();
				this.Hotspot.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Monster = new IMonsterItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Monster[i] = new IMonsterItem();
					this.Monster[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.RecMintmark = new IRecMintmark();
				this.RecMintmark.Parse(bytes, ref byteIndex);
			}
		}
	}
}
