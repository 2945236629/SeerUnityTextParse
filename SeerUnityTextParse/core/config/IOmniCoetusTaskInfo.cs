using System;

namespace core.config
{
	// Token: 0x02001E97 RID: 7831
	public class IOmniCoetusTaskInfo : IConfigItem
	{
		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600E658 RID: 58968 RVA: 0x003F03B0 File Offset: 0x003EE5B0
		// (set) Token: 0x0600E659 RID: 58969 RVA: 0x003F03B8 File Offset: 0x003EE5B8
		public string describe { get; set; }

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x003F03C1 File Offset: 0x003EE5C1
		// (set) Token: 0x0600E65B RID: 58971 RVA: 0x003F03C9 File Offset: 0x003EE5C9
		public string rewardinfo { get; set; }

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600E65C RID: 58972 RVA: 0x003F03D2 File Offset: 0x003EE5D2
		// (set) Token: 0x0600E65D RID: 58973 RVA: 0x003F03DA File Offset: 0x003EE5DA
		public int exp { get; set; }

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600E65E RID: 58974 RVA: 0x003F03E3 File Offset: 0x003EE5E3
		// (set) Token: 0x0600E65F RID: 58975 RVA: 0x003F03EB File Offset: 0x003EE5EB
		public int go { get; set; }

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x0600E660 RID: 58976 RVA: 0x003F03F4 File Offset: 0x003EE5F4
		// (set) Token: 0x0600E661 RID: 58977 RVA: 0x003F03FC File Offset: 0x003EE5FC
		public int id { get; set; }

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x0600E662 RID: 58978 RVA: 0x003F0405 File Offset: 0x003EE605
		// (set) Token: 0x0600E663 RID: 58979 RVA: 0x003F040D File Offset: 0x003EE60D
		public int shareExp { get; set; }

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x0600E664 RID: 58980 RVA: 0x003F0416 File Offset: 0x003EE616
		// (set) Token: 0x0600E665 RID: 58981 RVA: 0x003F041E File Offset: 0x003EE61E
		public int sorting { get; set; }

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600E666 RID: 58982 RVA: 0x003F0427 File Offset: 0x003EE627
		// (set) Token: 0x0600E667 RID: 58983 RVA: 0x003F042F File Offset: 0x003EE62F
		public int time { get; set; }

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x0600E668 RID: 58984 RVA: 0x003F0438 File Offset: 0x003EE638
		// (set) Token: 0x0600E669 RID: 58985 RVA: 0x003F0440 File Offset: 0x003EE640
		public int userinfo { get; set; }

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600E66A RID: 58986 RVA: 0x003F0449 File Offset: 0x003EE649
		// (set) Token: 0x0600E66B RID: 58987 RVA: 0x003F0451 File Offset: 0x003EE651
		public int value { get; set; }

		// Token: 0x0600E66C RID: 58988 RVA: 0x003F045C File Offset: 0x003EE65C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.shareExp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
