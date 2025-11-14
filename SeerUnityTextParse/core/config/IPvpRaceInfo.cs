using System;

namespace core.config
{
	// Token: 0x02001ECF RID: 7887
	public class IPvpRaceInfo : IConfigItem
	{
		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x0600E89A RID: 59546 RVA: 0x003F2FAC File Offset: 0x003F11AC
		// (set) Token: 0x0600E89B RID: 59547 RVA: 0x003F2FB4 File Offset: 0x003F11B4
		public int id { get; set; }

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x0600E89C RID: 59548 RVA: 0x003F2FBD File Offset: 0x003F11BD
		// (set) Token: 0x0600E89D RID: 59549 RVA: 0x003F2FC5 File Offset: 0x003F11C5
		public int round { get; set; }

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600E89E RID: 59550 RVA: 0x003F2FCE File Offset: 0x003F11CE
		// (set) Token: 0x0600E89F RID: 59551 RVA: 0x003F2FD6 File Offset: 0x003F11D6
		public int stage { get; set; }

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x003F2FDF File Offset: 0x003F11DF
		// (set) Token: 0x0600E8A1 RID: 59553 RVA: 0x003F2FE7 File Offset: 0x003F11E7
		public int time1 { get; set; }

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x003F2FF0 File Offset: 0x003F11F0
		// (set) Token: 0x0600E8A3 RID: 59555 RVA: 0x003F2FF8 File Offset: 0x003F11F8
		public int time2 { get; set; }

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600E8A4 RID: 59556 RVA: 0x003F3001 File Offset: 0x003F1201
		// (set) Token: 0x0600E8A5 RID: 59557 RVA: 0x003F3009 File Offset: 0x003F1209
		public int type { get; set; }

		// Token: 0x0600E8A6 RID: 59558 RVA: 0x003F3014 File Offset: 0x003F1214
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.round = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
