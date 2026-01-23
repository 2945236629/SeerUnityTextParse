using System;

namespace core.config
{
	// Token: 0x02001DA7 RID: 7591
	public class IElfGachaDetailsInfo : IConfigItem
	{
		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x0600E055 RID: 57429 RVA: 0x003E5F74 File Offset: 0x003E4174
		// (set) Token: 0x0600E056 RID: 57430 RVA: 0x003E5F7C File Offset: 0x003E417C
		public string itempro { get; set; }

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x0600E057 RID: 57431 RVA: 0x003E5F85 File Offset: 0x003E4185
		// (set) Token: 0x0600E058 RID: 57432 RVA: 0x003E5F8D File Offset: 0x003E418D
		public int id { get; set; }

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x0600E059 RID: 57433 RVA: 0x003E5F96 File Offset: 0x003E4196
		// (set) Token: 0x0600E05A RID: 57434 RVA: 0x003E5F9E File Offset: 0x003E419E
		public int item { get; set; }

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x0600E05B RID: 57435 RVA: 0x003E5FA7 File Offset: 0x003E41A7
		// (set) Token: 0x0600E05C RID: 57436 RVA: 0x003E5FAF File Offset: 0x003E41AF
		public int number { get; set; }

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x0600E05D RID: 57437 RVA: 0x003E5FB8 File Offset: 0x003E41B8
		// (set) Token: 0x0600E05E RID: 57438 RVA: 0x003E5FC0 File Offset: 0x003E41C0
		public int poolid { get; set; }

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x0600E05F RID: 57439 RVA: 0x003E5FC9 File Offset: 0x003E41C9
		// (set) Token: 0x0600E060 RID: 57440 RVA: 0x003E5FD1 File Offset: 0x003E41D1
		public int quality { get; set; }

		// Token: 0x0600E061 RID: 57441 RVA: 0x003E5FDC File Offset: 0x003E41DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itempro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
