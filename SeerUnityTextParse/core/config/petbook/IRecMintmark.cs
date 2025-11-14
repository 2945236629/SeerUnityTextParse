using System;

namespace core.config.petbook
{
	// Token: 0x02002061 RID: 8289
	public class IRecMintmark
	{
		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600F8D4 RID: 63700 RVA: 0x0040EECA File Offset: 0x0040D0CA
		// (set) Token: 0x0600F8D5 RID: 63701 RVA: 0x0040EED2 File Offset: 0x0040D0D2
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x0040EEDC File Offset: 0x0040D0DC
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
