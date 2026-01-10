using System;

namespace core.config
{
	// Token: 0x02001D10 RID: 7440
	public class IEqualShareGameShowInfo : IConfigItem
	{
		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x003D1C20 File Offset: 0x003CFE20
		// (set) Token: 0x0600DB83 RID: 56195 RVA: 0x003D1C28 File Offset: 0x003CFE28
		public string show { get; set; }

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x003D1C31 File Offset: 0x003CFE31
		// (set) Token: 0x0600DB85 RID: 56197 RVA: 0x003D1C39 File Offset: 0x003CFE39
		public int id { get; set; }

		// Token: 0x0600DB86 RID: 56198 RVA: 0x003D1C42 File Offset: 0x003CFE42
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.show = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
