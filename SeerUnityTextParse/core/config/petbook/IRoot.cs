using System;

namespace core.config.petbook
{
	// Token: 0x02002062 RID: 8290
	public class IRoot
	{
		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600F8D8 RID: 63704 RVA: 0x0040EF36 File Offset: 0x0040D136
		// (set) Token: 0x0600F8D9 RID: 63705 RVA: 0x0040EF3E File Offset: 0x0040D13E
		public IHotPet HotPet { get; set; }

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x0600F8DA RID: 63706 RVA: 0x0040EF47 File Offset: 0x0040D147
		// (set) Token: 0x0600F8DB RID: 63707 RVA: 0x0040EF4F File Offset: 0x0040D14F
		public IHotspot Hotspot { get; set; }

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x0600F8DC RID: 63708 RVA: 0x0040EF58 File Offset: 0x0040D158
		// (set) Token: 0x0600F8DD RID: 63709 RVA: 0x0040EF60 File Offset: 0x0040D160
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x0600F8DE RID: 63710 RVA: 0x0040EF69 File Offset: 0x0040D169
		// (set) Token: 0x0600F8DF RID: 63711 RVA: 0x0040EF71 File Offset: 0x0040D171
		public IRecMintmark RecMintmark { get; set; }

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x0040EF7C File Offset: 0x0040D17C
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
