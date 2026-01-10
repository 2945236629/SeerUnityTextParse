using System;

namespace core.config
{
	// Token: 0x02001D6C RID: 7532
	public class IMatchGameInfo : IConfigItem
	{
		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x003D687C File Offset: 0x003D4A7C
		// (set) Token: 0x0600DF3D RID: 57149 RVA: 0x003D6884 File Offset: 0x003D4A84
		public string beginning { get; set; }

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x0600DF3E RID: 57150 RVA: 0x003D688D File Offset: 0x003D4A8D
		// (set) Token: 0x0600DF3F RID: 57151 RVA: 0x003D6895 File Offset: 0x003D4A95
		public string describe { get; set; }

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x003D689E File Offset: 0x003D4A9E
		// (set) Token: 0x0600DF41 RID: 57153 RVA: 0x003D68A6 File Offset: 0x003D4AA6
		public string ending { get; set; }

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x003D68AF File Offset: 0x003D4AAF
		// (set) Token: 0x0600DF43 RID: 57155 RVA: 0x003D68B7 File Offset: 0x003D4AB7
		public string name { get; set; }

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x003D68C0 File Offset: 0x003D4AC0
		// (set) Token: 0x0600DF45 RID: 57157 RVA: 0x003D68C8 File Offset: 0x003D4AC8
		public string reward { get; set; }

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x003D68D1 File Offset: 0x003D4AD1
		// (set) Token: 0x0600DF47 RID: 57159 RVA: 0x003D68D9 File Offset: 0x003D4AD9
		public int Horizontal { get; set; }

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x0600DF48 RID: 57160 RVA: 0x003D68E2 File Offset: 0x003D4AE2
		// (set) Token: 0x0600DF49 RID: 57161 RVA: 0x003D68EA File Offset: 0x003D4AEA
		public int id { get; set; }

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x0600DF4A RID: 57162 RVA: 0x003D68F3 File Offset: 0x003D4AF3
		// (set) Token: 0x0600DF4B RID: 57163 RVA: 0x003D68FB File Offset: 0x003D4AFB
		public int npdSkin { get; set; }

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x003D6904 File Offset: 0x003D4B04
		// (set) Token: 0x0600DF4D RID: 57165 RVA: 0x003D690C File Offset: 0x003D4B0C
		public int score { get; set; }

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x0600DF4E RID: 57166 RVA: 0x003D6915 File Offset: 0x003D4B15
		// (set) Token: 0x0600DF4F RID: 57167 RVA: 0x003D691D File Offset: 0x003D4B1D
		public int time { get; set; }

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x003D6926 File Offset: 0x003D4B26
		// (set) Token: 0x0600DF51 RID: 57169 RVA: 0x003D692E File Offset: 0x003D4B2E
		public int Vertical { get; set; }

		// Token: 0x0600DF52 RID: 57170 RVA: 0x003D6938 File Offset: 0x003D4B38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Horizontal = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Vertical = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.npdSkin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.score = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
