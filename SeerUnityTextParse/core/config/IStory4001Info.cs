using System;

namespace core.config
{
	// Token: 0x02001FA6 RID: 8102
	public class IStory4001Info : IConfigItem
	{
		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x0600F498 RID: 62616 RVA: 0x00410F84 File Offset: 0x0040F184
		// (set) Token: 0x0600F499 RID: 62617 RVA: 0x00410F8C File Offset: 0x0040F18C
		public string param1 { get; set; }

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x0600F49A RID: 62618 RVA: 0x00410F95 File Offset: 0x0040F195
		// (set) Token: 0x0600F49B RID: 62619 RVA: 0x00410F9D File Offset: 0x0040F19D
		public string param2 { get; set; }

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x0600F49C RID: 62620 RVA: 0x00410FA6 File Offset: 0x0040F1A6
		// (set) Token: 0x0600F49D RID: 62621 RVA: 0x00410FAE File Offset: 0x0040F1AE
		public string param3 { get; set; }

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x0600F49E RID: 62622 RVA: 0x00410FB7 File Offset: 0x0040F1B7
		// (set) Token: 0x0600F49F RID: 62623 RVA: 0x00410FBF File Offset: 0x0040F1BF
		public string param4 { get; set; }

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x0600F4A0 RID: 62624 RVA: 0x00410FC8 File Offset: 0x0040F1C8
		// (set) Token: 0x0600F4A1 RID: 62625 RVA: 0x00410FD0 File Offset: 0x0040F1D0
		public string param5 { get; set; }

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x00410FD9 File Offset: 0x0040F1D9
		// (set) Token: 0x0600F4A3 RID: 62627 RVA: 0x00410FE1 File Offset: 0x0040F1E1
		public float control { get; set; }

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x0600F4A4 RID: 62628 RVA: 0x00410FEA File Offset: 0x0040F1EA
		// (set) Token: 0x0600F4A5 RID: 62629 RVA: 0x00410FF2 File Offset: 0x0040F1F2
		public int id { get; set; }

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x0600F4A6 RID: 62630 RVA: 0x00410FFB File Offset: 0x0040F1FB
		// (set) Token: 0x0600F4A7 RID: 62631 RVA: 0x00411003 File Offset: 0x0040F203
		public int logic { get; set; }

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x0600F4A8 RID: 62632 RVA: 0x0041100C File Offset: 0x0040F20C
		// (set) Token: 0x0600F4A9 RID: 62633 RVA: 0x00411014 File Offset: 0x0040F214
		public int next { get; set; }

		// Token: 0x0600F4AA RID: 62634 RVA: 0x00411020 File Offset: 0x0040F220
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
