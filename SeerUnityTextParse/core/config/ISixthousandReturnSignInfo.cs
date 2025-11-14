using System;

namespace core.config
{
	// Token: 0x02001F15 RID: 7957
	public class ISixthousandReturnSignInfo : IConfigItem
	{
		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x0600EBB6 RID: 60342 RVA: 0x003F6F28 File Offset: 0x003F5128
		// (set) Token: 0x0600EBB7 RID: 60343 RVA: 0x003F6F30 File Offset: 0x003F5130
		public string newreward1 { get; set; }

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x0600EBB8 RID: 60344 RVA: 0x003F6F39 File Offset: 0x003F5139
		// (set) Token: 0x0600EBB9 RID: 60345 RVA: 0x003F6F41 File Offset: 0x003F5141
		public string newreward2 { get; set; }

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x0600EBBA RID: 60346 RVA: 0x003F6F4A File Offset: 0x003F514A
		// (set) Token: 0x0600EBBB RID: 60347 RVA: 0x003F6F52 File Offset: 0x003F5152
		public string newreward3 { get; set; }

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x0600EBBC RID: 60348 RVA: 0x003F6F5B File Offset: 0x003F515B
		// (set) Token: 0x0600EBBD RID: 60349 RVA: 0x003F6F63 File Offset: 0x003F5163
		public string oldreward { get; set; }

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x0600EBBE RID: 60350 RVA: 0x003F6F6C File Offset: 0x003F516C
		// (set) Token: 0x0600EBBF RID: 60351 RVA: 0x003F6F74 File Offset: 0x003F5174
		public int id { get; set; }

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x003F6F80 File Offset: 0x003F5180
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.newreward1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.newreward2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.newreward3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.oldreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
