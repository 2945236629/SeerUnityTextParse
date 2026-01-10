using System;

namespace core.config
{
	// Token: 0x02001E6A RID: 7786
	public class ISunmoonStagewaveInfo : IConfigItem
	{
		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600EA66 RID: 60006 RVA: 0x003E45FC File Offset: 0x003E27FC
		// (set) Token: 0x0600EA67 RID: 60007 RVA: 0x003E4604 File Offset: 0x003E2804
		public int id { get; set; }

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x0600EA68 RID: 60008 RVA: 0x003E460D File Offset: 0x003E280D
		// (set) Token: 0x0600EA69 RID: 60009 RVA: 0x003E4615 File Offset: 0x003E2815
		public int isprompt { get; set; }

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600EA6A RID: 60010 RVA: 0x003E461E File Offset: 0x003E281E
		// (set) Token: 0x0600EA6B RID: 60011 RVA: 0x003E4626 File Offset: 0x003E2826
		public int stageid { get; set; }

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600EA6C RID: 60012 RVA: 0x003E462F File Offset: 0x003E282F
		// (set) Token: 0x0600EA6D RID: 60013 RVA: 0x003E4637 File Offset: 0x003E2837
		public int waveid { get; set; }

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x0600EA6E RID: 60014 RVA: 0x003E4640 File Offset: 0x003E2840
		// (set) Token: 0x0600EA6F RID: 60015 RVA: 0x003E4648 File Offset: 0x003E2848
		public int wavestarttime { get; set; }

		// Token: 0x0600EA70 RID: 60016 RVA: 0x003E4654 File Offset: 0x003E2854
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isprompt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.waveid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wavestarttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
