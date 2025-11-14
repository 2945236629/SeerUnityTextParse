using System;

namespace core.config
{
	// Token: 0x02001ECD RID: 7885
	public class IPvpQuiztaskInfo : IConfigItem
	{
		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x0600E88A RID: 59530 RVA: 0x003F2E48 File Offset: 0x003F1048
		// (set) Token: 0x0600E88B RID: 59531 RVA: 0x003F2E50 File Offset: 0x003F1050
		public string describe { get; set; }

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x0600E88C RID: 59532 RVA: 0x003F2E59 File Offset: 0x003F1059
		// (set) Token: 0x0600E88D RID: 59533 RVA: 0x003F2E61 File Offset: 0x003F1061
		public string[] rewardinfo { get; set; }

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x0600E88E RID: 59534 RVA: 0x003F2E6A File Offset: 0x003F106A
		// (set) Token: 0x0600E88F RID: 59535 RVA: 0x003F2E72 File Offset: 0x003F1072
		public int id { get; set; }

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600E890 RID: 59536 RVA: 0x003F2E7B File Offset: 0x003F107B
		// (set) Token: 0x0600E891 RID: 59537 RVA: 0x003F2E83 File Offset: 0x003F1083
		public int jumptarget { get; set; }

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x0600E892 RID: 59538 RVA: 0x003F2E8C File Offset: 0x003F108C
		// (set) Token: 0x0600E893 RID: 59539 RVA: 0x003F2E94 File Offset: 0x003F1094
		public int value { get; set; }

		// Token: 0x0600E894 RID: 59540 RVA: 0x003F2EA0 File Offset: 0x003F10A0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jumptarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
