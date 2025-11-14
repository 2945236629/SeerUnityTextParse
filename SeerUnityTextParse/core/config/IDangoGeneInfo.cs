using System;

namespace core.config
{
	// Token: 0x02001DF7 RID: 7671
	public class IDangoGeneInfo : IConfigItem
	{
		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x003E83F4 File Offset: 0x003E65F4
		// (set) Token: 0x0600DFF9 RID: 57337 RVA: 0x003E83FC File Offset: 0x003E65FC
		public string name { get; set; }

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x003E8405 File Offset: 0x003E6605
		// (set) Token: 0x0600DFFB RID: 57339 RVA: 0x003E840D File Offset: 0x003E660D
		public string skinbaby { get; set; }

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x003E8416 File Offset: 0x003E6616
		// (set) Token: 0x0600DFFD RID: 57341 RVA: 0x003E841E File Offset: 0x003E661E
		public string skinteen { get; set; }

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x003E8427 File Offset: 0x003E6627
		// (set) Token: 0x0600DFFF RID: 57343 RVA: 0x003E842F File Offset: 0x003E662F
		public int geneID { get; set; }

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x003E8438 File Offset: 0x003E6638
		// (set) Token: 0x0600E001 RID: 57345 RVA: 0x003E8440 File Offset: 0x003E6640
		public int id { get; set; }

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x0600E002 RID: 57346 RVA: 0x003E8449 File Offset: 0x003E6649
		// (set) Token: 0x0600E003 RID: 57347 RVA: 0x003E8451 File Offset: 0x003E6651
		public int value { get; set; }

		// Token: 0x0600E004 RID: 57348 RVA: 0x003E845C File Offset: 0x003E665C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.geneID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skinbaby = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skinteen = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
