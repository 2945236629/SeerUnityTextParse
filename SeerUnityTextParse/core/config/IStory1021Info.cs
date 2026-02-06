using System;

namespace core.config
{
	// Token: 0x02001F92 RID: 8082
	public class IStory1021Info : IConfigItem
	{
		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600F3A8 RID: 62376 RVA: 0x0040FDDC File Offset: 0x0040DFDC
		// (set) Token: 0x0600F3A9 RID: 62377 RVA: 0x0040FDE4 File Offset: 0x0040DFE4
		public string param1 { get; set; }

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600F3AA RID: 62378 RVA: 0x0040FDED File Offset: 0x0040DFED
		// (set) Token: 0x0600F3AB RID: 62379 RVA: 0x0040FDF5 File Offset: 0x0040DFF5
		public string param2 { get; set; }

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x0600F3AC RID: 62380 RVA: 0x0040FDFE File Offset: 0x0040DFFE
		// (set) Token: 0x0600F3AD RID: 62381 RVA: 0x0040FE06 File Offset: 0x0040E006
		public string param3 { get; set; }

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x0600F3AE RID: 62382 RVA: 0x0040FE0F File Offset: 0x0040E00F
		// (set) Token: 0x0600F3AF RID: 62383 RVA: 0x0040FE17 File Offset: 0x0040E017
		public string param4 { get; set; }

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x0040FE20 File Offset: 0x0040E020
		// (set) Token: 0x0600F3B1 RID: 62385 RVA: 0x0040FE28 File Offset: 0x0040E028
		public string param5 { get; set; }

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x0600F3B2 RID: 62386 RVA: 0x0040FE31 File Offset: 0x0040E031
		// (set) Token: 0x0600F3B3 RID: 62387 RVA: 0x0040FE39 File Offset: 0x0040E039
		public float control { get; set; }

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x0040FE42 File Offset: 0x0040E042
		// (set) Token: 0x0600F3B5 RID: 62389 RVA: 0x0040FE4A File Offset: 0x0040E04A
		public int id { get; set; }

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x0040FE53 File Offset: 0x0040E053
		// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x0040FE5B File Offset: 0x0040E05B
		public int logic { get; set; }

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x0600F3B8 RID: 62392 RVA: 0x0040FE64 File Offset: 0x0040E064
		// (set) Token: 0x0600F3B9 RID: 62393 RVA: 0x0040FE6C File Offset: 0x0040E06C
		public int next { get; set; }

		// Token: 0x0600F3BA RID: 62394 RVA: 0x0040FE78 File Offset: 0x0040E078
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
