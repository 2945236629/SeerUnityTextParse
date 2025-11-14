using System;

namespace core.config
{
	// Token: 0x02001DFB RID: 7675
	public class IDangoGuideInfo : IConfigItem
	{
		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x003E8650 File Offset: 0x003E6850
		// (set) Token: 0x0600E019 RID: 57369 RVA: 0x003E8658 File Offset: 0x003E6858
		public string dangoMovie { get; set; }

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x003E8661 File Offset: 0x003E6861
		// (set) Token: 0x0600E01B RID: 57371 RVA: 0x003E8669 File Offset: 0x003E6869
		public string describe { get; set; }

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600E01C RID: 57372 RVA: 0x003E8672 File Offset: 0x003E6872
		// (set) Token: 0x0600E01D RID: 57373 RVA: 0x003E867A File Offset: 0x003E687A
		public string reward { get; set; }

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600E01E RID: 57374 RVA: 0x003E8683 File Offset: 0x003E6883
		// (set) Token: 0x0600E01F RID: 57375 RVA: 0x003E868B File Offset: 0x003E688B
		public string titile { get; set; }

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600E020 RID: 57376 RVA: 0x003E8694 File Offset: 0x003E6894
		// (set) Token: 0x0600E021 RID: 57377 RVA: 0x003E869C File Offset: 0x003E689C
		public int id { get; set; }

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600E022 RID: 57378 RVA: 0x003E86A5 File Offset: 0x003E68A5
		// (set) Token: 0x0600E023 RID: 57379 RVA: 0x003E86AD File Offset: 0x003E68AD
		public int type { get; set; }

		// Token: 0x0600E024 RID: 57380 RVA: 0x003E86B8 File Offset: 0x003E68B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.dangoMovie = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.titile = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
