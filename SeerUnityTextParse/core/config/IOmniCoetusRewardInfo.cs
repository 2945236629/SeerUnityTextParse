using System;

namespace core.config
{
	// Token: 0x02001E95 RID: 7829
	public class IOmniCoetusRewardInfo : IConfigItem
	{
		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x0600E64A RID: 58954 RVA: 0x003F02AC File Offset: 0x003EE4AC
		// (set) Token: 0x0600E64B RID: 58955 RVA: 0x003F02B4 File Offset: 0x003EE4B4
		public string reward { get; set; }

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600E64C RID: 58956 RVA: 0x003F02BD File Offset: 0x003EE4BD
		// (set) Token: 0x0600E64D RID: 58957 RVA: 0x003F02C5 File Offset: 0x003EE4C5
		public int exp { get; set; }

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x0600E64E RID: 58958 RVA: 0x003F02CE File Offset: 0x003EE4CE
		// (set) Token: 0x0600E64F RID: 58959 RVA: 0x003F02D6 File Offset: 0x003EE4D6
		public int id { get; set; }

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x0600E650 RID: 58960 RVA: 0x003F02DF File Offset: 0x003EE4DF
		// (set) Token: 0x0600E651 RID: 58961 RVA: 0x003F02E7 File Offset: 0x003EE4E7
		public int stat { get; set; }

		// Token: 0x0600E652 RID: 58962 RVA: 0x003F02F0 File Offset: 0x003EE4F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
