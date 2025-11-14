using System;

namespace core.config.petbook_temp
{
	// Token: 0x0200204C RID: 8268
	public class IRoot
	{
		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x0600F820 RID: 63520 RVA: 0x0040E036 File Offset: 0x0040C236
		// (set) Token: 0x0600F821 RID: 63521 RVA: 0x0040E03E File Offset: 0x0040C23E
		public IHotPet HotPet { get; set; }

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x0600F822 RID: 63522 RVA: 0x0040E047 File Offset: 0x0040C247
		// (set) Token: 0x0600F823 RID: 63523 RVA: 0x0040E04F File Offset: 0x0040C24F
		public IHotspot Hotspot { get; set; }

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x0600F824 RID: 63524 RVA: 0x0040E058 File Offset: 0x0040C258
		// (set) Token: 0x0600F825 RID: 63525 RVA: 0x0040E060 File Offset: 0x0040C260
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x0600F826 RID: 63526 RVA: 0x0040E069 File Offset: 0x0040C269
		// (set) Token: 0x0600F827 RID: 63527 RVA: 0x0040E071 File Offset: 0x0040C271
		public IRecMintmark RecMintmark { get; set; }

		// Token: 0x0600F828 RID: 63528 RVA: 0x0040E07C File Offset: 0x0040C27C
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
