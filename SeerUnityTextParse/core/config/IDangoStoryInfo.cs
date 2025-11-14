using System;

namespace core.config
{
	// Token: 0x02001E05 RID: 7685
	public class IDangoStoryInfo : IConfigItem
	{
		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x0600E084 RID: 57476 RVA: 0x003E8E2C File Offset: 0x003E702C
		// (set) Token: 0x0600E085 RID: 57477 RVA: 0x003E8E34 File Offset: 0x003E7034
		public string describe { get; set; }

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x003E8E3D File Offset: 0x003E703D
		// (set) Token: 0x0600E087 RID: 57479 RVA: 0x003E8E45 File Offset: 0x003E7045
		public int dangoID { get; set; }

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x0600E088 RID: 57480 RVA: 0x003E8E4E File Offset: 0x003E704E
		// (set) Token: 0x0600E089 RID: 57481 RVA: 0x003E8E56 File Offset: 0x003E7056
		public int dangoTask { get; set; }

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600E08A RID: 57482 RVA: 0x003E8E5F File Offset: 0x003E705F
		// (set) Token: 0x0600E08B RID: 57483 RVA: 0x003E8E67 File Offset: 0x003E7067
		public int id { get; set; }

		// Token: 0x0600E08C RID: 57484 RVA: 0x003E8E70 File Offset: 0x003E7070
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.dangoID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dangoTask = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
