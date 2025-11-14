using System;

namespace core.config
{
	// Token: 0x02001EAB RID: 7851
	public class IPetSkinRewardtypeInfo : IConfigItem
	{
		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x0600E734 RID: 59188 RVA: 0x003F13A8 File Offset: 0x003EF5A8
		// (set) Token: 0x0600E735 RID: 59189 RVA: 0x003F13B0 File Offset: 0x003EF5B0
		public string name { get; set; }

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x0600E736 RID: 59190 RVA: 0x003F13B9 File Offset: 0x003EF5B9
		// (set) Token: 0x0600E737 RID: 59191 RVA: 0x003F13C1 File Offset: 0x003EF5C1
		public string subtypename { get; set; }

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x0600E738 RID: 59192 RVA: 0x003F13CA File Offset: 0x003EF5CA
		// (set) Token: 0x0600E739 RID: 59193 RVA: 0x003F13D2 File Offset: 0x003EF5D2
		public int id { get; set; }

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x0600E73A RID: 59194 RVA: 0x003F13DB File Offset: 0x003EF5DB
		// (set) Token: 0x0600E73B RID: 59195 RVA: 0x003F13E3 File Offset: 0x003EF5E3
		public int sort { get; set; }

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x0600E73C RID: 59196 RVA: 0x003F13EC File Offset: 0x003EF5EC
		// (set) Token: 0x0600E73D RID: 59197 RVA: 0x003F13F4 File Offset: 0x003EF5F4
		public int subtype { get; set; }

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x0600E73E RID: 59198 RVA: 0x003F13FD File Offset: 0x003EF5FD
		// (set) Token: 0x0600E73F RID: 59199 RVA: 0x003F1405 File Offset: 0x003EF605
		public int type { get; set; }

		// Token: 0x0600E740 RID: 59200 RVA: 0x003F1410 File Offset: 0x003EF610
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subtypename = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
