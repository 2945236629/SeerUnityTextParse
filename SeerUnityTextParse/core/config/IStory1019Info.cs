using System;

namespace core.config
{
	// Token: 0x02001E4C RID: 7756
	public class IStory1019Info : IConfigItem
	{
		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x0600E902 RID: 59650 RVA: 0x003E2C08 File Offset: 0x003E0E08
		// (set) Token: 0x0600E903 RID: 59651 RVA: 0x003E2C10 File Offset: 0x003E0E10
		public string param1 { get; set; }

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x0600E904 RID: 59652 RVA: 0x003E2C19 File Offset: 0x003E0E19
		// (set) Token: 0x0600E905 RID: 59653 RVA: 0x003E2C21 File Offset: 0x003E0E21
		public string param2 { get; set; }

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x0600E906 RID: 59654 RVA: 0x003E2C2A File Offset: 0x003E0E2A
		// (set) Token: 0x0600E907 RID: 59655 RVA: 0x003E2C32 File Offset: 0x003E0E32
		public string param3 { get; set; }

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x0600E908 RID: 59656 RVA: 0x003E2C3B File Offset: 0x003E0E3B
		// (set) Token: 0x0600E909 RID: 59657 RVA: 0x003E2C43 File Offset: 0x003E0E43
		public string param4 { get; set; }

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x0600E90A RID: 59658 RVA: 0x003E2C4C File Offset: 0x003E0E4C
		// (set) Token: 0x0600E90B RID: 59659 RVA: 0x003E2C54 File Offset: 0x003E0E54
		public string param5 { get; set; }

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x0600E90C RID: 59660 RVA: 0x003E2C5D File Offset: 0x003E0E5D
		// (set) Token: 0x0600E90D RID: 59661 RVA: 0x003E2C65 File Offset: 0x003E0E65
		public float control { get; set; }

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x0600E90E RID: 59662 RVA: 0x003E2C6E File Offset: 0x003E0E6E
		// (set) Token: 0x0600E90F RID: 59663 RVA: 0x003E2C76 File Offset: 0x003E0E76
		public int id { get; set; }

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600E910 RID: 59664 RVA: 0x003E2C7F File Offset: 0x003E0E7F
		// (set) Token: 0x0600E911 RID: 59665 RVA: 0x003E2C87 File Offset: 0x003E0E87
		public int logic { get; set; }

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x003E2C90 File Offset: 0x003E0E90
		// (set) Token: 0x0600E913 RID: 59667 RVA: 0x003E2C98 File Offset: 0x003E0E98
		public int next { get; set; }

		// Token: 0x0600E914 RID: 59668 RVA: 0x003E2CA4 File Offset: 0x003E0EA4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
