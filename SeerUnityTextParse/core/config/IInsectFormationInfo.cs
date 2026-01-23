using System;

namespace core.config
{
	// Token: 0x02001DE1 RID: 7649
	public class IInsectFormationInfo : IConfigItem
	{
		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x003E8F30 File Offset: 0x003E7130
		// (set) Token: 0x0600E2AE RID: 58030 RVA: 0x003E8F38 File Offset: 0x003E7138
		public string Abscissa { get; set; }

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x003E8F41 File Offset: 0x003E7141
		// (set) Token: 0x0600E2B0 RID: 58032 RVA: 0x003E8F49 File Offset: 0x003E7149
		public string LockExclude { get; set; }

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x003E8F52 File Offset: 0x003E7152
		// (set) Token: 0x0600E2B2 RID: 58034 RVA: 0x003E8F5A File Offset: 0x003E715A
		public string LockSymbol { get; set; }

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x003E8F63 File Offset: 0x003E7163
		// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x003E8F6B File Offset: 0x003E716B
		public string Ordinate { get; set; }

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x003E8F74 File Offset: 0x003E7174
		// (set) Token: 0x0600E2B6 RID: 58038 RVA: 0x003E8F7C File Offset: 0x003E717C
		public string Prompt { get; set; }

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600E2B7 RID: 58039 RVA: 0x003E8F85 File Offset: 0x003E7185
		// (set) Token: 0x0600E2B8 RID: 58040 RVA: 0x003E8F8D File Offset: 0x003E718D
		public string Target { get; set; }

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x003E8F96 File Offset: 0x003E7196
		// (set) Token: 0x0600E2BA RID: 58042 RVA: 0x003E8F9E File Offset: 0x003E719E
		public int id { get; set; }

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x0600E2BB RID: 58043 RVA: 0x003E8FA7 File Offset: 0x003E71A7
		// (set) Token: 0x0600E2BC RID: 58044 RVA: 0x003E8FAF File Offset: 0x003E71AF
		public int Level { get; set; }

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x003E8FB8 File Offset: 0x003E71B8
		// (set) Token: 0x0600E2BE RID: 58046 RVA: 0x003E8FC0 File Offset: 0x003E71C0
		public int Sort { get; set; }

		// Token: 0x0600E2BF RID: 58047 RVA: 0x003E8FCC File Offset: 0x003E71CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Abscissa = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LockExclude = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.LockSymbol = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Ordinate = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Prompt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
