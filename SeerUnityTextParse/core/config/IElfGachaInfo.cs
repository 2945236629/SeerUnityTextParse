using System;

namespace core.config
{
	// Token: 0x02001DA5 RID: 7589
	public class IElfGachaInfo : IConfigItem
	{
		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x0600E035 RID: 57397 RVA: 0x003E5D44 File Offset: 0x003E3F44
		// (set) Token: 0x0600E036 RID: 57398 RVA: 0x003E5D4C File Offset: 0x003E3F4C
		public string endtime { get; set; }

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600E037 RID: 57399 RVA: 0x003E5D55 File Offset: 0x003E3F55
		// (set) Token: 0x0600E038 RID: 57400 RVA: 0x003E5D5D File Offset: 0x003E3F5D
		public string name { get; set; }

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x0600E039 RID: 57401 RVA: 0x003E5D66 File Offset: 0x003E3F66
		// (set) Token: 0x0600E03A RID: 57402 RVA: 0x003E5D6E File Offset: 0x003E3F6E
		public string starttime { get; set; }

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x0600E03B RID: 57403 RVA: 0x003E5D77 File Offset: 0x003E3F77
		// (set) Token: 0x0600E03C RID: 57404 RVA: 0x003E5D7F File Offset: 0x003E3F7F
		public int cost1 { get; set; }

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x0600E03D RID: 57405 RVA: 0x003E5D88 File Offset: 0x003E3F88
		// (set) Token: 0x0600E03E RID: 57406 RVA: 0x003E5D90 File Offset: 0x003E3F90
		public int discost { get; set; }

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x0600E03F RID: 57407 RVA: 0x003E5D99 File Offset: 0x003E3F99
		// (set) Token: 0x0600E040 RID: 57408 RVA: 0x003E5DA1 File Offset: 0x003E3FA1
		public int disitem { get; set; }

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x0600E041 RID: 57409 RVA: 0x003E5DAA File Offset: 0x003E3FAA
		// (set) Token: 0x0600E042 RID: 57410 RVA: 0x003E5DB2 File Offset: 0x003E3FB2
		public int id { get; set; }

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x0600E043 RID: 57411 RVA: 0x003E5DBB File Offset: 0x003E3FBB
		// (set) Token: 0x0600E044 RID: 57412 RVA: 0x003E5DC3 File Offset: 0x003E3FC3
		public int miditem { get; set; }

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x0600E045 RID: 57413 RVA: 0x003E5DCC File Offset: 0x003E3FCC
		// (set) Token: 0x0600E046 RID: 57414 RVA: 0x003E5DD4 File Offset: 0x003E3FD4
		public int poolid { get; set; }

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x0600E047 RID: 57415 RVA: 0x003E5DDD File Offset: 0x003E3FDD
		// (set) Token: 0x0600E048 RID: 57416 RVA: 0x003E5DE5 File Offset: 0x003E3FE5
		public int Sitem { get; set; }

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x0600E049 RID: 57417 RVA: 0x003E5DEE File Offset: 0x003E3FEE
		// (set) Token: 0x0600E04A RID: 57418 RVA: 0x003E5DF6 File Offset: 0x003E3FF6
		public int SSitem { get; set; }

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x0600E04B RID: 57419 RVA: 0x003E5DFF File Offset: 0x003E3FFF
		// (set) Token: 0x0600E04C RID: 57420 RVA: 0x003E5E07 File Offset: 0x003E4007
		public int taskred { get; set; }

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x0600E04D RID: 57421 RVA: 0x003E5E10 File Offset: 0x003E4010
		// (set) Token: 0x0600E04E RID: 57422 RVA: 0x003E5E18 File Offset: 0x003E4018
		public int ticket { get; set; }

		// Token: 0x0600E04F RID: 57423 RVA: 0x003E5E24 File Offset: 0x003E4024
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.SSitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cost1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.discost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.disitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.miditem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskred = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ticket = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
