using System;

namespace core.config
{
	// Token: 0x02001EB0 RID: 7856
	public class IMintmarkElevareInfo : IConfigItem
	{
		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x00403850 File Offset: 0x00401A50
		// (set) Token: 0x0600E9C9 RID: 59849 RVA: 0x00403858 File Offset: 0x00401A58
		public string desc { get; set; }

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x00403861 File Offset: 0x00401A61
		// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x00403869 File Offset: 0x00401A69
		public int[] cost { get; set; }

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x00403872 File Offset: 0x00401A72
		// (set) Token: 0x0600E9CD RID: 59853 RVA: 0x0040387A File Offset: 0x00401A7A
		public int elevareMintmark { get; set; }

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600E9CE RID: 59854 RVA: 0x00403883 File Offset: 0x00401A83
		// (set) Token: 0x0600E9CF RID: 59855 RVA: 0x0040388B File Offset: 0x00401A8B
		public int id { get; set; }

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x00403894 File Offset: 0x00401A94
		// (set) Token: 0x0600E9D1 RID: 59857 RVA: 0x0040389C File Offset: 0x00401A9C
		public int originMintmark { get; set; }

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x0600E9D2 RID: 59858 RVA: 0x004038A5 File Offset: 0x00401AA5
		// (set) Token: 0x0600E9D3 RID: 59859 RVA: 0x004038AD File Offset: 0x00401AAD
		public int primumMintmark { get; set; }

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x0600E9D4 RID: 59860 RVA: 0x004038B6 File Offset: 0x00401AB6
		// (set) Token: 0x0600E9D5 RID: 59861 RVA: 0x004038BE File Offset: 0x00401ABE
		public int statinfo { get; set; }

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600E9D6 RID: 59862 RVA: 0x004038C7 File Offset: 0x00401AC7
		// (set) Token: 0x0600E9D7 RID: 59863 RVA: 0x004038CF File Offset: 0x00401ACF
		public int type { get; set; }

		// Token: 0x0600E9D8 RID: 59864 RVA: 0x004038D8 File Offset: 0x00401AD8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.cost = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.cost[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.elevareMintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.originMintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.primumMintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.statinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
