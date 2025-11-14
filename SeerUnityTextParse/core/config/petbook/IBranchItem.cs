using System;

namespace core.config.petbook
{
	// Token: 0x0200205A RID: 8282
	public class IBranchItem
	{
		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x0600F892 RID: 63634 RVA: 0x0040E99F File Offset: 0x0040CB9F
		// (set) Token: 0x0600F893 RID: 63635 RVA: 0x0040E9A7 File Offset: 0x0040CBA7
		public string intro { get; set; }

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x0600F894 RID: 63636 RVA: 0x0040E9B0 File Offset: 0x0040CBB0
		// (set) Token: 0x0600F895 RID: 63637 RVA: 0x0040E9B8 File Offset: 0x0040CBB8
		public IPlaceItem[] place { get; set; }

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0600F896 RID: 63638 RVA: 0x0040E9C1 File Offset: 0x0040CBC1
		// (set) Token: 0x0600F897 RID: 63639 RVA: 0x0040E9C9 File Offset: 0x0040CBC9
		public string title { get; set; }

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x0600F898 RID: 63640 RVA: 0x0040E9D2 File Offset: 0x0040CBD2
		// (set) Token: 0x0600F899 RID: 63641 RVA: 0x0040E9DA File Offset: 0x0040CBDA
		public int ID { get; set; }

		// Token: 0x0600F89A RID: 63642 RVA: 0x0040E9E4 File Offset: 0x0040CBE4
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
