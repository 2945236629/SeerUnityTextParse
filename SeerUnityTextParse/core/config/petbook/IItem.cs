using System;

namespace core.config.petbook
{
	// Token: 0x0200205D RID: 8285
	public class IItem
	{
		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x0040EB73 File Offset: 0x0040CD73
		// (set) Token: 0x0600F8A7 RID: 63655 RVA: 0x0040EB7B File Offset: 0x0040CD7B
		public string intro { get; set; }

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x0600F8A8 RID: 63656 RVA: 0x0040EB84 File Offset: 0x0040CD84
		// (set) Token: 0x0600F8A9 RID: 63657 RVA: 0x0040EB8C File Offset: 0x0040CD8C
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F8AA RID: 63658 RVA: 0x0040EB98 File Offset: 0x0040CD98
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
