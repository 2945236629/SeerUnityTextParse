using System;

namespace core.config
{
	// Token: 0x02001E48 RID: 7752
	public class IStory1013Info : IConfigItem
	{
		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600E8D2 RID: 59602 RVA: 0x003E2880 File Offset: 0x003E0A80
		// (set) Token: 0x0600E8D3 RID: 59603 RVA: 0x003E2888 File Offset: 0x003E0A88
		public string param1 { get; set; }

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x0600E8D4 RID: 59604 RVA: 0x003E2891 File Offset: 0x003E0A91
		// (set) Token: 0x0600E8D5 RID: 59605 RVA: 0x003E2899 File Offset: 0x003E0A99
		public string param2 { get; set; }

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x0600E8D6 RID: 59606 RVA: 0x003E28A2 File Offset: 0x003E0AA2
		// (set) Token: 0x0600E8D7 RID: 59607 RVA: 0x003E28AA File Offset: 0x003E0AAA
		public string param3 { get; set; }

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x003E28B3 File Offset: 0x003E0AB3
		// (set) Token: 0x0600E8D9 RID: 59609 RVA: 0x003E28BB File Offset: 0x003E0ABB
		public string param4 { get; set; }

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x0600E8DA RID: 59610 RVA: 0x003E28C4 File Offset: 0x003E0AC4
		// (set) Token: 0x0600E8DB RID: 59611 RVA: 0x003E28CC File Offset: 0x003E0ACC
		public string param5 { get; set; }

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x003E28D5 File Offset: 0x003E0AD5
		// (set) Token: 0x0600E8DD RID: 59613 RVA: 0x003E28DD File Offset: 0x003E0ADD
		public float control { get; set; }

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600E8DE RID: 59614 RVA: 0x003E28E6 File Offset: 0x003E0AE6
		// (set) Token: 0x0600E8DF RID: 59615 RVA: 0x003E28EE File Offset: 0x003E0AEE
		public int id { get; set; }

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x003E28F7 File Offset: 0x003E0AF7
		// (set) Token: 0x0600E8E1 RID: 59617 RVA: 0x003E28FF File Offset: 0x003E0AFF
		public int logic { get; set; }

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600E8E2 RID: 59618 RVA: 0x003E2908 File Offset: 0x003E0B08
		// (set) Token: 0x0600E8E3 RID: 59619 RVA: 0x003E2910 File Offset: 0x003E0B10
		public int next { get; set; }

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x003E291C File Offset: 0x003E0B1C
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
