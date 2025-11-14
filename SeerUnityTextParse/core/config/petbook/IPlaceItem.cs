using System;

namespace core.config.petbook
{
	// Token: 0x02002060 RID: 8288
	public class IPlaceItem
	{
		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x0040ED64 File Offset: 0x0040CF64
		// (set) Token: 0x0600F8C1 RID: 63681 RVA: 0x0040ED6C File Offset: 0x0040CF6C
		public string Desc { get; set; }

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x0040ED75 File Offset: 0x0040CF75
		// (set) Token: 0x0600F8C3 RID: 63683 RVA: 0x0040ED7D File Offset: 0x0040CF7D
		public string Go { get; set; }

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x0600F8C4 RID: 63684 RVA: 0x0040ED86 File Offset: 0x0040CF86
		// (set) Token: 0x0600F8C5 RID: 63685 RVA: 0x0040ED8E File Offset: 0x0040CF8E
		public string Redirect { get; set; }

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600F8C6 RID: 63686 RVA: 0x0040ED97 File Offset: 0x0040CF97
		// (set) Token: 0x0600F8C7 RID: 63687 RVA: 0x0040ED9F File Offset: 0x0040CF9F
		public int[] Mintmark { get; set; }

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x0600F8C8 RID: 63688 RVA: 0x0040EDA8 File Offset: 0x0040CFA8
		// (set) Token: 0x0600F8C9 RID: 63689 RVA: 0x0040EDB0 File Offset: 0x0040CFB0
		public int ID { get; set; }

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x0600F8CA RID: 63690 RVA: 0x0040EDB9 File Offset: 0x0040CFB9
		// (set) Token: 0x0600F8CB RID: 63691 RVA: 0x0040EDC1 File Offset: 0x0040CFC1
		public int ImageID { get; set; }

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600F8CC RID: 63692 RVA: 0x0040EDCA File Offset: 0x0040CFCA
		// (set) Token: 0x0600F8CD RID: 63693 RVA: 0x0040EDD2 File Offset: 0x0040CFD2
		public int Label { get; set; }

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600F8CE RID: 63694 RVA: 0x0040EDDB File Offset: 0x0040CFDB
		// (set) Token: 0x0600F8CF RID: 63695 RVA: 0x0040EDE3 File Offset: 0x0040CFE3
		public int monID { get; set; }

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600F8D0 RID: 63696 RVA: 0x0040EDEC File Offset: 0x0040CFEC
		// (set) Token: 0x0600F8D1 RID: 63697 RVA: 0x0040EDF4 File Offset: 0x0040CFF4
		public int type { get; set; }

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x0040EE00 File Offset: 0x0040D000
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ImageID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Mintmark = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.Mintmark[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.Redirect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
