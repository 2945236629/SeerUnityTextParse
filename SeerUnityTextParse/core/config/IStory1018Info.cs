using System;

namespace core.config
{
	// Token: 0x02001E4A RID: 7754
	public class IStory1018Info : IConfigItem
	{
		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600E8EA RID: 59626 RVA: 0x003E2A44 File Offset: 0x003E0C44
		// (set) Token: 0x0600E8EB RID: 59627 RVA: 0x003E2A4C File Offset: 0x003E0C4C
		public string param1 { get; set; }

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x003E2A55 File Offset: 0x003E0C55
		// (set) Token: 0x0600E8ED RID: 59629 RVA: 0x003E2A5D File Offset: 0x003E0C5D
		public string param2 { get; set; }

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x003E2A66 File Offset: 0x003E0C66
		// (set) Token: 0x0600E8EF RID: 59631 RVA: 0x003E2A6E File Offset: 0x003E0C6E
		public string param3 { get; set; }

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x003E2A77 File Offset: 0x003E0C77
		// (set) Token: 0x0600E8F1 RID: 59633 RVA: 0x003E2A7F File Offset: 0x003E0C7F
		public string param4 { get; set; }

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x0600E8F2 RID: 59634 RVA: 0x003E2A88 File Offset: 0x003E0C88
		// (set) Token: 0x0600E8F3 RID: 59635 RVA: 0x003E2A90 File Offset: 0x003E0C90
		public string param5 { get; set; }

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x003E2A99 File Offset: 0x003E0C99
		// (set) Token: 0x0600E8F5 RID: 59637 RVA: 0x003E2AA1 File Offset: 0x003E0CA1
		public float control { get; set; }

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x0600E8F6 RID: 59638 RVA: 0x003E2AAA File Offset: 0x003E0CAA
		// (set) Token: 0x0600E8F7 RID: 59639 RVA: 0x003E2AB2 File Offset: 0x003E0CB2
		public int id { get; set; }

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x0600E8F8 RID: 59640 RVA: 0x003E2ABB File Offset: 0x003E0CBB
		// (set) Token: 0x0600E8F9 RID: 59641 RVA: 0x003E2AC3 File Offset: 0x003E0CC3
		public int logic { get; set; }

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600E8FA RID: 59642 RVA: 0x003E2ACC File Offset: 0x003E0CCC
		// (set) Token: 0x0600E8FB RID: 59643 RVA: 0x003E2AD4 File Offset: 0x003E0CD4
		public int next { get; set; }

		// Token: 0x0600E8FC RID: 59644 RVA: 0x003E2AE0 File Offset: 0x003E0CE0
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
