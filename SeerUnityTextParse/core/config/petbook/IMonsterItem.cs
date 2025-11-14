using System;

namespace core.config.petbook
{
	// Token: 0x0200205E RID: 8286
	public class IMonsterItem
	{
		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x0600F8AC RID: 63660 RVA: 0x0040EC06 File Offset: 0x0040CE06
		// (set) Token: 0x0600F8AD RID: 63661 RVA: 0x0040EC0E File Offset: 0x0040CE0E
		public string DefName { get; set; }

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600F8AE RID: 63662 RVA: 0x0040EC17 File Offset: 0x0040CE17
		// (set) Token: 0x0600F8AF RID: 63663 RVA: 0x0040EC1F File Offset: 0x0040CE1F
		public string Features { get; set; }

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600F8B0 RID: 63664 RVA: 0x0040EC28 File Offset: 0x0040CE28
		// (set) Token: 0x0600F8B1 RID: 63665 RVA: 0x0040EC30 File Offset: 0x0040CE30
		public string Target { get; set; }

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x0600F8B2 RID: 63666 RVA: 0x0040EC39 File Offset: 0x0040CE39
		// (set) Token: 0x0600F8B3 RID: 63667 RVA: 0x0040EC41 File Offset: 0x0040CE41
		public int ID { get; set; }

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x0040EC4C File Offset: 0x0040CE4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
