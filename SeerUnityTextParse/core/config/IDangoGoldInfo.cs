using System;

namespace core.config
{
	// Token: 0x02001DF9 RID: 7673
	public class IDangoGoldInfo : IConfigItem
	{
		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600E00A RID: 57354 RVA: 0x003E8550 File Offset: 0x003E6750
		// (set) Token: 0x0600E00B RID: 57355 RVA: 0x003E8558 File Offset: 0x003E6758
		public int dangoGold { get; set; }

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600E00C RID: 57356 RVA: 0x003E8561 File Offset: 0x003E6761
		// (set) Token: 0x0600E00D RID: 57357 RVA: 0x003E8569 File Offset: 0x003E6769
		public int dangoNumMax { get; set; }

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x0600E00E RID: 57358 RVA: 0x003E8572 File Offset: 0x003E6772
		// (set) Token: 0x0600E00F RID: 57359 RVA: 0x003E857A File Offset: 0x003E677A
		public int dangoNumMix { get; set; }

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600E010 RID: 57360 RVA: 0x003E8583 File Offset: 0x003E6783
		// (set) Token: 0x0600E011 RID: 57361 RVA: 0x003E858B File Offset: 0x003E678B
		public int id { get; set; }

		// Token: 0x0600E012 RID: 57362 RVA: 0x003E8594 File Offset: 0x003E6794
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.dangoGold = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dangoNumMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dangoNumMix = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
