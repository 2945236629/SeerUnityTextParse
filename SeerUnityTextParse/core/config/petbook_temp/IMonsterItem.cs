using System;

namespace core.config.petbook_temp
{
	// Token: 0x02002048 RID: 8264
	public class IMonsterItem
	{
		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x0600F7F2 RID: 63474 RVA: 0x0040DCE2 File Offset: 0x0040BEE2
		// (set) Token: 0x0600F7F3 RID: 63475 RVA: 0x0040DCEA File Offset: 0x0040BEEA
		public string DefName { get; set; }

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600F7F4 RID: 63476 RVA: 0x0040DCF3 File Offset: 0x0040BEF3
		// (set) Token: 0x0600F7F5 RID: 63477 RVA: 0x0040DCFB File Offset: 0x0040BEFB
		public string Features { get; set; }

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x0600F7F6 RID: 63478 RVA: 0x0040DD04 File Offset: 0x0040BF04
		// (set) Token: 0x0600F7F7 RID: 63479 RVA: 0x0040DD0C File Offset: 0x0040BF0C
		public string Target { get; set; }

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x0600F7F8 RID: 63480 RVA: 0x0040DD15 File Offset: 0x0040BF15
		// (set) Token: 0x0600F7F9 RID: 63481 RVA: 0x0040DD1D File Offset: 0x0040BF1D
		public string Tyjumptargetpe { get; set; }

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600F7FA RID: 63482 RVA: 0x0040DD26 File Offset: 0x0040BF26
		// (set) Token: 0x0600F7FB RID: 63483 RVA: 0x0040DD2E File Offset: 0x0040BF2E
		public int ID { get; set; }

		// Token: 0x0600F7FC RID: 63484 RVA: 0x0040DD38 File Offset: 0x0040BF38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Tyjumptargetpe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
