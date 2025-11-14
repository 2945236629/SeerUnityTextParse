using System;

namespace core.config
{
	// Token: 0x02001E03 RID: 7683
	public class IDangoSlotInfo : IConfigItem
	{
		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600E076 RID: 57462 RVA: 0x003E8D28 File Offset: 0x003E6F28
		// (set) Token: 0x0600E077 RID: 57463 RVA: 0x003E8D30 File Offset: 0x003E6F30
		public string name { get; set; }

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600E078 RID: 57464 RVA: 0x003E8D39 File Offset: 0x003E6F39
		// (set) Token: 0x0600E079 RID: 57465 RVA: 0x003E8D41 File Offset: 0x003E6F41
		public int id { get; set; }

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x0600E07A RID: 57466 RVA: 0x003E8D4A File Offset: 0x003E6F4A
		// (set) Token: 0x0600E07B RID: 57467 RVA: 0x003E8D52 File Offset: 0x003E6F52
		public int petID { get; set; }

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x0600E07C RID: 57468 RVA: 0x003E8D5B File Offset: 0x003E6F5B
		// (set) Token: 0x0600E07D RID: 57469 RVA: 0x003E8D63 File Offset: 0x003E6F63
		public int value { get; set; }

		// Token: 0x0600E07E RID: 57470 RVA: 0x003E8D6C File Offset: 0x003E6F6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
