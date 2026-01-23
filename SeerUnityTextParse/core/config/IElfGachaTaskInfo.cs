using System;

namespace core.config
{
	// Token: 0x02001DAB RID: 7595
	public class IElfGachaTaskInfo : IConfigItem
	{
		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600E089 RID: 57481 RVA: 0x003E6308 File Offset: 0x003E4508
		// (set) Token: 0x0600E08A RID: 57482 RVA: 0x003E6310 File Offset: 0x003E4510
		public string endtime { get; set; }

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600E08B RID: 57483 RVA: 0x003E6319 File Offset: 0x003E4519
		// (set) Token: 0x0600E08C RID: 57484 RVA: 0x003E6321 File Offset: 0x003E4521
		public string rewardinfo { get; set; }

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600E08D RID: 57485 RVA: 0x003E632A File Offset: 0x003E452A
		// (set) Token: 0x0600E08E RID: 57486 RVA: 0x003E6332 File Offset: 0x003E4532
		public string title { get; set; }

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600E08F RID: 57487 RVA: 0x003E633B File Offset: 0x003E453B
		// (set) Token: 0x0600E090 RID: 57488 RVA: 0x003E6343 File Offset: 0x003E4543
		public int id { get; set; }

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x0600E091 RID: 57489 RVA: 0x003E634C File Offset: 0x003E454C
		// (set) Token: 0x0600E092 RID: 57490 RVA: 0x003E6354 File Offset: 0x003E4554
		public int NewMsglogId { get; set; }

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x0600E093 RID: 57491 RVA: 0x003E635D File Offset: 0x003E455D
		// (set) Token: 0x0600E094 RID: 57492 RVA: 0x003E6365 File Offset: 0x003E4565
		public int poolid { get; set; }

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x0600E095 RID: 57493 RVA: 0x003E636E File Offset: 0x003E456E
		// (set) Token: 0x0600E096 RID: 57494 RVA: 0x003E6376 File Offset: 0x003E4576
		public int taskid { get; set; }

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600E097 RID: 57495 RVA: 0x003E637F File Offset: 0x003E457F
		// (set) Token: 0x0600E098 RID: 57496 RVA: 0x003E6387 File Offset: 0x003E4587
		public int value { get; set; }

		// Token: 0x0600E099 RID: 57497 RVA: 0x003E6390 File Offset: 0x003E4590
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
