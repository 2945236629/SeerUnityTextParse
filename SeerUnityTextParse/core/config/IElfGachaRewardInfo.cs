using System;

namespace core.config
{
	// Token: 0x02001DA9 RID: 7593
	public class IElfGachaRewardInfo : IConfigItem
	{
		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600E067 RID: 57447 RVA: 0x003E60C4 File Offset: 0x003E42C4
		// (set) Token: 0x0600E068 RID: 57448 RVA: 0x003E60CC File Offset: 0x003E42CC
		public string endtime { get; set; }

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x0600E069 RID: 57449 RVA: 0x003E60D5 File Offset: 0x003E42D5
		// (set) Token: 0x0600E06A RID: 57450 RVA: 0x003E60DD File Offset: 0x003E42DD
		public string starttime { get; set; }

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x0600E06B RID: 57451 RVA: 0x003E60E6 File Offset: 0x003E42E6
		// (set) Token: 0x0600E06C RID: 57452 RVA: 0x003E60EE File Offset: 0x003E42EE
		public int consumeid { get; set; }

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600E06D RID: 57453 RVA: 0x003E60F7 File Offset: 0x003E42F7
		// (set) Token: 0x0600E06E RID: 57454 RVA: 0x003E60FF File Offset: 0x003E42FF
		public int consumnum { get; set; }

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600E06F RID: 57455 RVA: 0x003E6108 File Offset: 0x003E4308
		// (set) Token: 0x0600E070 RID: 57456 RVA: 0x003E6110 File Offset: 0x003E4310
		public int id { get; set; }

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x0600E071 RID: 57457 RVA: 0x003E6119 File Offset: 0x003E4319
		// (set) Token: 0x0600E072 RID: 57458 RVA: 0x003E6121 File Offset: 0x003E4321
		public int NewMsglogId { get; set; }

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x0600E073 RID: 57459 RVA: 0x003E612A File Offset: 0x003E432A
		// (set) Token: 0x0600E074 RID: 57460 RVA: 0x003E6132 File Offset: 0x003E4332
		public int Pet5thMove { get; set; }

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x0600E075 RID: 57461 RVA: 0x003E613B File Offset: 0x003E433B
		// (set) Token: 0x0600E076 RID: 57462 RVA: 0x003E6143 File Offset: 0x003E4343
		public int PetID { get; set; }

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x0600E077 RID: 57463 RVA: 0x003E614C File Offset: 0x003E434C
		// (set) Token: 0x0600E078 RID: 57464 RVA: 0x003E6154 File Offset: 0x003E4354
		public int PetLimit { get; set; }

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600E079 RID: 57465 RVA: 0x003E615D File Offset: 0x003E435D
		// (set) Token: 0x0600E07A RID: 57466 RVA: 0x003E6165 File Offset: 0x003E4365
		public int PetMint { get; set; }

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600E07B RID: 57467 RVA: 0x003E616E File Offset: 0x003E436E
		// (set) Token: 0x0600E07C RID: 57468 RVA: 0x003E6176 File Offset: 0x003E4376
		public int PetNewseId { get; set; }

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600E07D RID: 57469 RVA: 0x003E617F File Offset: 0x003E437F
		// (set) Token: 0x0600E07E RID: 57470 RVA: 0x003E6187 File Offset: 0x003E4387
		public int poolid { get; set; }

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x0600E07F RID: 57471 RVA: 0x003E6190 File Offset: 0x003E4390
		// (set) Token: 0x0600E080 RID: 57472 RVA: 0x003E6198 File Offset: 0x003E4398
		public int pooltype { get; set; }

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600E081 RID: 57473 RVA: 0x003E61A1 File Offset: 0x003E43A1
		// (set) Token: 0x0600E082 RID: 57474 RVA: 0x003E61A9 File Offset: 0x003E43A9
		public int quality { get; set; }

		// Token: 0x0600E083 RID: 57475 RVA: 0x003E61B4 File Offset: 0x003E43B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Pet5thMove = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetMint = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetNewseId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.consumeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.consumnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pooltype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
