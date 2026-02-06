using System;

namespace core.config
{
	// Token: 0x02001E78 RID: 7800
	public class IIndianaSpiritInfo : IConfigItem
	{
		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x0600E782 RID: 59266 RVA: 0x00400AC0 File Offset: 0x003FECC0
		// (set) Token: 0x0600E783 RID: 59267 RVA: 0x00400AC8 File Offset: 0x003FECC8
		public int id { get; set; }

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x0600E784 RID: 59268 RVA: 0x00400AD1 File Offset: 0x003FECD1
		// (set) Token: 0x0600E785 RID: 59269 RVA: 0x00400AD9 File Offset: 0x003FECD9
		public int mintmarkID { get; set; }

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x0600E786 RID: 59270 RVA: 0x00400AE2 File Offset: 0x003FECE2
		// (set) Token: 0x0600E787 RID: 59271 RVA: 0x00400AEA File Offset: 0x003FECEA
		public int newSeID { get; set; }

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x0600E788 RID: 59272 RVA: 0x00400AF3 File Offset: 0x003FECF3
		// (set) Token: 0x0600E789 RID: 59273 RVA: 0x00400AFB File Offset: 0x003FECFB
		public int petid { get; set; }

		// Token: 0x0600E78A RID: 59274 RVA: 0x00400B04 File Offset: 0x003FED04
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.newSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
