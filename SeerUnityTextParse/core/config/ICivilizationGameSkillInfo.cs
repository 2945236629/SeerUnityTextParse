using System;

namespace core.config
{
	// Token: 0x02001CBC RID: 7356
	public class ICivilizationGameSkillInfo : IConfigItem
	{
		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600D85C RID: 55388 RVA: 0x003CDFAC File Offset: 0x003CC1AC
		// (set) Token: 0x0600D85D RID: 55389 RVA: 0x003CDFB4 File Offset: 0x003CC1B4
		public string consume { get; set; }

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600D85E RID: 55390 RVA: 0x003CDFBD File Offset: 0x003CC1BD
		// (set) Token: 0x0600D85F RID: 55391 RVA: 0x003CDFC5 File Offset: 0x003CC1C5
		public string describe { get; set; }

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600D860 RID: 55392 RVA: 0x003CDFCE File Offset: 0x003CC1CE
		// (set) Token: 0x0600D861 RID: 55393 RVA: 0x003CDFD6 File Offset: 0x003CC1D6
		public string effective { get; set; }

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600D862 RID: 55394 RVA: 0x003CDFDF File Offset: 0x003CC1DF
		// (set) Token: 0x0600D863 RID: 55395 RVA: 0x003CDFE7 File Offset: 0x003CC1E7
		public string front { get; set; }

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600D864 RID: 55396 RVA: 0x003CDFF0 File Offset: 0x003CC1F0
		// (set) Token: 0x0600D865 RID: 55397 RVA: 0x003CDFF8 File Offset: 0x003CC1F8
		public string name { get; set; }

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600D866 RID: 55398 RVA: 0x003CE001 File Offset: 0x003CC201
		// (set) Token: 0x0600D867 RID: 55399 RVA: 0x003CE009 File Offset: 0x003CC209
		public string range { get; set; }

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x0600D868 RID: 55400 RVA: 0x003CE012 File Offset: 0x003CC212
		// (set) Token: 0x0600D869 RID: 55401 RVA: 0x003CE01A File Offset: 0x003CC21A
		public string use { get; set; }

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x0600D86A RID: 55402 RVA: 0x003CE023 File Offset: 0x003CC223
		// (set) Token: 0x0600D86B RID: 55403 RVA: 0x003CE02B File Offset: 0x003CC22B
		public int id { get; set; }

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x0600D86C RID: 55404 RVA: 0x003CE034 File Offset: 0x003CC234
		// (set) Token: 0x0600D86D RID: 55405 RVA: 0x003CE03C File Offset: 0x003CC23C
		public int replace { get; set; }

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x0600D86E RID: 55406 RVA: 0x003CE045 File Offset: 0x003CC245
		// (set) Token: 0x0600D86F RID: 55407 RVA: 0x003CE04D File Offset: 0x003CC24D
		public int sort { get; set; }

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600D870 RID: 55408 RVA: 0x003CE056 File Offset: 0x003CC256
		// (set) Token: 0x0600D871 RID: 55409 RVA: 0x003CE05E File Offset: 0x003CC25E
		public int type { get; set; }

		// Token: 0x0600D872 RID: 55410 RVA: 0x003CE068 File Offset: 0x003CC268
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.consume = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.effective = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.front = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.range = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.replace = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.use = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
