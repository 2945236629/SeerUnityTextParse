using System;

namespace core.config.petbook_temp
{
	// Token: 0x02002044 RID: 8260
	public class IBranchItem
	{
		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x0600F7D8 RID: 63448 RVA: 0x0040DA7B File Offset: 0x0040BC7B
		// (set) Token: 0x0600F7D9 RID: 63449 RVA: 0x0040DA83 File Offset: 0x0040BC83
		public string intro { get; set; }

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x0600F7DA RID: 63450 RVA: 0x0040DA8C File Offset: 0x0040BC8C
		// (set) Token: 0x0600F7DB RID: 63451 RVA: 0x0040DA94 File Offset: 0x0040BC94
		public IPlaceItem[] place { get; set; }

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x0600F7DC RID: 63452 RVA: 0x0040DA9D File Offset: 0x0040BC9D
		// (set) Token: 0x0600F7DD RID: 63453 RVA: 0x0040DAA5 File Offset: 0x0040BCA5
		public string title { get; set; }

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x0600F7DE RID: 63454 RVA: 0x0040DAAE File Offset: 0x0040BCAE
		// (set) Token: 0x0600F7DF RID: 63455 RVA: 0x0040DAB6 File Offset: 0x0040BCB6
		public int ID { get; set; }

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x0040DAC0 File Offset: 0x0040BCC0
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
