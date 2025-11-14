using System;

namespace core.config.petbook_temp
{
	// Token: 0x0200204B RID: 8267
	public class IRecMintmark
	{
		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x0600F81C RID: 63516 RVA: 0x0040DFCA File Offset: 0x0040C1CA
		// (set) Token: 0x0600F81D RID: 63517 RVA: 0x0040DFD2 File Offset: 0x0040C1D2
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F81E RID: 63518 RVA: 0x0040DFDC File Offset: 0x0040C1DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
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
		}
	}
}
