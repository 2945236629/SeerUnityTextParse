using System;

namespace core.config
{
	// Token: 0x02001DAD RID: 7597
	public class IElGachaInfo : IConfigItem
	{
		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600E09F RID: 57503 RVA: 0x003E64A0 File Offset: 0x003E46A0
		// (set) Token: 0x0600E0A0 RID: 57504 RVA: 0x003E64A8 File Offset: 0x003E46A8
		public string endtime { get; set; }

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x0600E0A1 RID: 57505 RVA: 0x003E64B1 File Offset: 0x003E46B1
		// (set) Token: 0x0600E0A2 RID: 57506 RVA: 0x003E64B9 File Offset: 0x003E46B9
		public string name { get; set; }

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x0600E0A3 RID: 57507 RVA: 0x003E64C2 File Offset: 0x003E46C2
		// (set) Token: 0x0600E0A4 RID: 57508 RVA: 0x003E64CA File Offset: 0x003E46CA
		public string starttime { get; set; }

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x0600E0A5 RID: 57509 RVA: 0x003E64D3 File Offset: 0x003E46D3
		// (set) Token: 0x0600E0A6 RID: 57510 RVA: 0x003E64DB File Offset: 0x003E46DB
		public int id { get; set; }

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x0600E0A7 RID: 57511 RVA: 0x003E64E4 File Offset: 0x003E46E4
		// (set) Token: 0x0600E0A8 RID: 57512 RVA: 0x003E64EC File Offset: 0x003E46EC
		public int poolid { get; set; }

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x003E64F5 File Offset: 0x003E46F5
		// (set) Token: 0x0600E0AA RID: 57514 RVA: 0x003E64FD File Offset: 0x003E46FD
		public int Sitem { get; set; }

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x0600E0AB RID: 57515 RVA: 0x003E6506 File Offset: 0x003E4706
		// (set) Token: 0x0600E0AC RID: 57516 RVA: 0x003E650E File Offset: 0x003E470E
		public int SSitem { get; set; }

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x003E6517 File Offset: 0x003E4717
		// (set) Token: 0x0600E0AE RID: 57518 RVA: 0x003E651F File Offset: 0x003E471F
		public int ticket { get; set; }

		// Token: 0x0600E0AF RID: 57519 RVA: 0x003E6528 File Offset: 0x003E4728
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.SSitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ticket = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
