using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002056 RID: 8278
	public class IRecMintmark
	{
		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x0600F878 RID: 63608 RVA: 0x0040E74A File Offset: 0x0040C94A
		// (set) Token: 0x0600F879 RID: 63609 RVA: 0x0040E752 File Offset: 0x0040C952
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F87A RID: 63610 RVA: 0x0040E75C File Offset: 0x0040C95C
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
