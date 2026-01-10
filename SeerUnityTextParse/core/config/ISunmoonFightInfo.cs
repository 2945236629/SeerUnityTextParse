using System;

namespace core.config
{
	// Token: 0x02001E66 RID: 7782
	public class ISunmoonFightInfo : IConfigItem
	{
		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600EA40 RID: 59968 RVA: 0x003E4334 File Offset: 0x003E2534
		// (set) Token: 0x0600EA41 RID: 59969 RVA: 0x003E433C File Offset: 0x003E253C
		public string line { get; set; }

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600EA42 RID: 59970 RVA: 0x003E4345 File Offset: 0x003E2545
		// (set) Token: 0x0600EA43 RID: 59971 RVA: 0x003E434D File Offset: 0x003E254D
		public string monster { get; set; }

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600EA44 RID: 59972 RVA: 0x003E4356 File Offset: 0x003E2556
		// (set) Token: 0x0600EA45 RID: 59973 RVA: 0x003E435E File Offset: 0x003E255E
		public int delaytime { get; set; }

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x0600EA46 RID: 59974 RVA: 0x003E4367 File Offset: 0x003E2567
		// (set) Token: 0x0600EA47 RID: 59975 RVA: 0x003E436F File Offset: 0x003E256F
		public int id { get; set; }

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x0600EA48 RID: 59976 RVA: 0x003E4378 File Offset: 0x003E2578
		// (set) Token: 0x0600EA49 RID: 59977 RVA: 0x003E4380 File Offset: 0x003E2580
		public int stageid { get; set; }

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x0600EA4A RID: 59978 RVA: 0x003E4389 File Offset: 0x003E2589
		// (set) Token: 0x0600EA4B RID: 59979 RVA: 0x003E4391 File Offset: 0x003E2591
		public int waveid { get; set; }

		// Token: 0x0600EA4C RID: 59980 RVA: 0x003E439C File Offset: 0x003E259C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.delaytime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.line = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.waveid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
