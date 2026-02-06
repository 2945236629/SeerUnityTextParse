using System;

namespace core.config
{
	// Token: 0x02001E30 RID: 7728
	public class IDragonboatExploratioLevelInfo : IConfigItem
	{
		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600E490 RID: 58512 RVA: 0x003FCFA4 File Offset: 0x003FB1A4
		// (set) Token: 0x0600E491 RID: 58513 RVA: 0x003FCFAC File Offset: 0x003FB1AC
		public string plotOrigin { get; set; }

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600E492 RID: 58514 RVA: 0x003FCFB5 File Offset: 0x003FB1B5
		// (set) Token: 0x0600E493 RID: 58515 RVA: 0x003FCFBD File Offset: 0x003FB1BD
		public string plotStorage { get; set; }

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600E494 RID: 58516 RVA: 0x003FCFC6 File Offset: 0x003FB1C6
		// (set) Token: 0x0600E495 RID: 58517 RVA: 0x003FCFCE File Offset: 0x003FB1CE
		public string rewardSpace { get; set; }

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600E496 RID: 58518 RVA: 0x003FCFD7 File Offset: 0x003FB1D7
		// (set) Token: 0x0600E497 RID: 58519 RVA: 0x003FCFDF File Offset: 0x003FB1DF
		public string space { get; set; }

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x0600E498 RID: 58520 RVA: 0x003FCFE8 File Offset: 0x003FB1E8
		// (set) Token: 0x0600E499 RID: 58521 RVA: 0x003FCFF0 File Offset: 0x003FB1F0
		public int id { get; set; }

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x0600E49A RID: 58522 RVA: 0x003FCFF9 File Offset: 0x003FB1F9
		// (set) Token: 0x0600E49B RID: 58523 RVA: 0x003FD001 File Offset: 0x003FB201
		public int originSpace { get; set; }

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x0600E49C RID: 58524 RVA: 0x003FD00A File Offset: 0x003FB20A
		// (set) Token: 0x0600E49D RID: 58525 RVA: 0x003FD012 File Offset: 0x003FB212
		public int plotLimit { get; set; }

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x003FD01B File Offset: 0x003FB21B
		// (set) Token: 0x0600E49F RID: 58527 RVA: 0x003FD023 File Offset: 0x003FB223
		public int unlocktime { get; set; }

		// Token: 0x0600E4A0 RID: 58528 RVA: 0x003FD02C File Offset: 0x003FB22C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.originSpace = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.plotLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.plotOrigin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.plotStorage = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardSpace = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.space = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlocktime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
