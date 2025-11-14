using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002053 RID: 8275
	public class IMonsterItem
	{
		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x0600F850 RID: 63568 RVA: 0x0040E486 File Offset: 0x0040C686
		// (set) Token: 0x0600F851 RID: 63569 RVA: 0x0040E48E File Offset: 0x0040C68E
		public string DefName { get; set; }

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x0600F852 RID: 63570 RVA: 0x0040E497 File Offset: 0x0040C697
		// (set) Token: 0x0600F853 RID: 63571 RVA: 0x0040E49F File Offset: 0x0040C69F
		public string Features { get; set; }

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x0600F854 RID: 63572 RVA: 0x0040E4A8 File Offset: 0x0040C6A8
		// (set) Token: 0x0600F855 RID: 63573 RVA: 0x0040E4B0 File Offset: 0x0040C6B0
		public string Target { get; set; }

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x0600F856 RID: 63574 RVA: 0x0040E4B9 File Offset: 0x0040C6B9
		// (set) Token: 0x0600F857 RID: 63575 RVA: 0x0040E4C1 File Offset: 0x0040C6C1
		public int ID { get; set; }

		// Token: 0x0600F858 RID: 63576 RVA: 0x0040E4CC File Offset: 0x0040C6CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
