using System;

namespace core.config.petbook_temp
{
	// Token: 0x0200204A RID: 8266
	public class IPlaceItem
	{
		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x0600F808 RID: 63496 RVA: 0x0040DE64 File Offset: 0x0040C064
		// (set) Token: 0x0600F809 RID: 63497 RVA: 0x0040DE6C File Offset: 0x0040C06C
		public string Desc { get; set; }

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x0600F80A RID: 63498 RVA: 0x0040DE75 File Offset: 0x0040C075
		// (set) Token: 0x0600F80B RID: 63499 RVA: 0x0040DE7D File Offset: 0x0040C07D
		public string Go { get; set; }

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x0600F80C RID: 63500 RVA: 0x0040DE86 File Offset: 0x0040C086
		// (set) Token: 0x0600F80D RID: 63501 RVA: 0x0040DE8E File Offset: 0x0040C08E
		public string Redirect { get; set; }

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x0600F80E RID: 63502 RVA: 0x0040DE97 File Offset: 0x0040C097
		// (set) Token: 0x0600F80F RID: 63503 RVA: 0x0040DE9F File Offset: 0x0040C09F
		public int[] Mintmark { get; set; }

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x0600F810 RID: 63504 RVA: 0x0040DEA8 File Offset: 0x0040C0A8
		// (set) Token: 0x0600F811 RID: 63505 RVA: 0x0040DEB0 File Offset: 0x0040C0B0
		public int ID { get; set; }

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600F812 RID: 63506 RVA: 0x0040DEB9 File Offset: 0x0040C0B9
		// (set) Token: 0x0600F813 RID: 63507 RVA: 0x0040DEC1 File Offset: 0x0040C0C1
		public int ImageID { get; set; }

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600F814 RID: 63508 RVA: 0x0040DECA File Offset: 0x0040C0CA
		// (set) Token: 0x0600F815 RID: 63509 RVA: 0x0040DED2 File Offset: 0x0040C0D2
		public int Label { get; set; }

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x0600F816 RID: 63510 RVA: 0x0040DEDB File Offset: 0x0040C0DB
		// (set) Token: 0x0600F817 RID: 63511 RVA: 0x0040DEE3 File Offset: 0x0040C0E3
		public int monID { get; set; }

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x0600F818 RID: 63512 RVA: 0x0040DEEC File Offset: 0x0040C0EC
		// (set) Token: 0x0600F819 RID: 63513 RVA: 0x0040DEF4 File Offset: 0x0040C0F4
		public int type { get; set; }

		// Token: 0x0600F81A RID: 63514 RVA: 0x0040DF00 File Offset: 0x0040C100
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
