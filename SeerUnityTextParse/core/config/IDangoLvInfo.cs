using System;

namespace core.config
{
	// Token: 0x02001DFF RID: 7679
	public class IDangoLvInfo : IConfigItem
	{
		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x0600E038 RID: 57400 RVA: 0x003E88B8 File Offset: 0x003E6AB8
		// (set) Token: 0x0600E039 RID: 57401 RVA: 0x003E88C0 File Offset: 0x003E6AC0
		public string describe1 { get; set; }

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x0600E03A RID: 57402 RVA: 0x003E88C9 File Offset: 0x003E6AC9
		// (set) Token: 0x0600E03B RID: 57403 RVA: 0x003E88D1 File Offset: 0x003E6AD1
		public string describe2 { get; set; }

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600E03C RID: 57404 RVA: 0x003E88DA File Offset: 0x003E6ADA
		// (set) Token: 0x0600E03D RID: 57405 RVA: 0x003E88E2 File Offset: 0x003E6AE2
		public string describe3 { get; set; }

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600E03E RID: 57406 RVA: 0x003E88EB File Offset: 0x003E6AEB
		// (set) Token: 0x0600E03F RID: 57407 RVA: 0x003E88F3 File Offset: 0x003E6AF3
		public int[] dangoTask { get; set; }

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600E040 RID: 57408 RVA: 0x003E88FC File Offset: 0x003E6AFC
		// (set) Token: 0x0600E041 RID: 57409 RVA: 0x003E8904 File Offset: 0x003E6B04
		public int benefit1 { get; set; }

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600E042 RID: 57410 RVA: 0x003E890D File Offset: 0x003E6B0D
		// (set) Token: 0x0600E043 RID: 57411 RVA: 0x003E8915 File Offset: 0x003E6B15
		public int benefit2 { get; set; }

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600E044 RID: 57412 RVA: 0x003E891E File Offset: 0x003E6B1E
		// (set) Token: 0x0600E045 RID: 57413 RVA: 0x003E8926 File Offset: 0x003E6B26
		public int benefit3 { get; set; }

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600E046 RID: 57414 RVA: 0x003E892F File Offset: 0x003E6B2F
		// (set) Token: 0x0600E047 RID: 57415 RVA: 0x003E8937 File Offset: 0x003E6B37
		public int id { get; set; }

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600E048 RID: 57416 RVA: 0x003E8940 File Offset: 0x003E6B40
		// (set) Token: 0x0600E049 RID: 57417 RVA: 0x003E8948 File Offset: 0x003E6B48
		public int minorNum { get; set; }

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x0600E04A RID: 57418 RVA: 0x003E8951 File Offset: 0x003E6B51
		// (set) Token: 0x0600E04B RID: 57419 RVA: 0x003E8959 File Offset: 0x003E6B59
		public int reward { get; set; }

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600E04C RID: 57420 RVA: 0x003E8962 File Offset: 0x003E6B62
		// (set) Token: 0x0600E04D RID: 57421 RVA: 0x003E896A File Offset: 0x003E6B6A
		public int taskNum { get; set; }

		// Token: 0x0600E04E RID: 57422 RVA: 0x003E8974 File Offset: 0x003E6B74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.benefit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.benefit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.benefit3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.dangoTask = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.dangoTask[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.describe1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.minorNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.taskNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
