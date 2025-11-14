using System;

namespace core.config.petbook_temp
{
	// Token: 0x02002047 RID: 8263
	public class IItem
	{
		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x0600F7EC RID: 63468 RVA: 0x0040DC4F File Offset: 0x0040BE4F
		// (set) Token: 0x0600F7ED RID: 63469 RVA: 0x0040DC57 File Offset: 0x0040BE57
		public string intro { get; set; }

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x0600F7EE RID: 63470 RVA: 0x0040DC60 File Offset: 0x0040BE60
		// (set) Token: 0x0600F7EF RID: 63471 RVA: 0x0040DC68 File Offset: 0x0040BE68
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F7F0 RID: 63472 RVA: 0x0040DC74 File Offset: 0x0040BE74
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
