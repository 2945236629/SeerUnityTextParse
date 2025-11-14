using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002052 RID: 8274
	public class IItem
	{
		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x0600F84A RID: 63562 RVA: 0x0040E3F3 File Offset: 0x0040C5F3
		// (set) Token: 0x0600F84B RID: 63563 RVA: 0x0040E3FB File Offset: 0x0040C5FB
		public string intro { get; set; }

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x0600F84C RID: 63564 RVA: 0x0040E404 File Offset: 0x0040C604
		// (set) Token: 0x0600F84D RID: 63565 RVA: 0x0040E40C File Offset: 0x0040C60C
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F84E RID: 63566 RVA: 0x0040E418 File Offset: 0x0040C618
		public void Parse(byte[] bytes, ref int byteIndex)
		{
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
		}
	}
}
