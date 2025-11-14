using System;

namespace core.config
{
	// Token: 0x02001ECB RID: 7883
	public class IPvpQuizshopInfo : IConfigItem
	{
		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x0600E874 RID: 59508 RVA: 0x003F2CC8 File Offset: 0x003F0EC8
		// (set) Token: 0x0600E875 RID: 59509 RVA: 0x003F2CD0 File Offset: 0x003F0ED0
		public int consumeitemid { get; set; }

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x0600E876 RID: 59510 RVA: 0x003F2CD9 File Offset: 0x003F0ED9
		// (set) Token: 0x0600E877 RID: 59511 RVA: 0x003F2CE1 File Offset: 0x003F0EE1
		public int id { get; set; }

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x0600E878 RID: 59512 RVA: 0x003F2CEA File Offset: 0x003F0EEA
		// (set) Token: 0x0600E879 RID: 59513 RVA: 0x003F2CF2 File Offset: 0x003F0EF2
		public int limit { get; set; }

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x0600E87A RID: 59514 RVA: 0x003F2CFB File Offset: 0x003F0EFB
		// (set) Token: 0x0600E87B RID: 59515 RVA: 0x003F2D03 File Offset: 0x003F0F03
		public int price { get; set; }

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x0600E87C RID: 59516 RVA: 0x003F2D0C File Offset: 0x003F0F0C
		// (set) Token: 0x0600E87D RID: 59517 RVA: 0x003F2D14 File Offset: 0x003F0F14
		public int product { get; set; }

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x0600E87E RID: 59518 RVA: 0x003F2D1D File Offset: 0x003F0F1D
		// (set) Token: 0x0600E87F RID: 59519 RVA: 0x003F2D25 File Offset: 0x003F0F25
		public int productnum { get; set; }

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x003F2D2E File Offset: 0x003F0F2E
		// (set) Token: 0x0600E881 RID: 59521 RVA: 0x003F2D36 File Offset: 0x003F0F36
		public int producttype { get; set; }

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x0600E882 RID: 59522 RVA: 0x003F2D3F File Offset: 0x003F0F3F
		// (set) Token: 0x0600E883 RID: 59523 RVA: 0x003F2D47 File Offset: 0x003F0F47
		public int quantity { get; set; }

		// Token: 0x0600E884 RID: 59524 RVA: 0x003F2D50 File Offset: 0x003F0F50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.product = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.producttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
