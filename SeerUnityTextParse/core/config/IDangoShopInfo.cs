using System;

namespace core.config
{
	// Token: 0x02001E01 RID: 7681
	public class IDangoShopInfo : IConfigItem
	{
		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600E054 RID: 57428 RVA: 0x003E8AD4 File Offset: 0x003E6CD4
		// (set) Token: 0x0600E055 RID: 57429 RVA: 0x003E8ADC File Offset: 0x003E6CDC
		public string describe1 { get; set; }

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600E056 RID: 57430 RVA: 0x003E8AE5 File Offset: 0x003E6CE5
		// (set) Token: 0x0600E057 RID: 57431 RVA: 0x003E8AED File Offset: 0x003E6CED
		public string describe2 { get; set; }

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600E058 RID: 57432 RVA: 0x003E8AF6 File Offset: 0x003E6CF6
		// (set) Token: 0x0600E059 RID: 57433 RVA: 0x003E8AFE File Offset: 0x003E6CFE
		public string rewardinfo { get; set; }

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x0600E05A RID: 57434 RVA: 0x003E8B07 File Offset: 0x003E6D07
		// (set) Token: 0x0600E05B RID: 57435 RVA: 0x003E8B0F File Offset: 0x003E6D0F
		public string title { get; set; }

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x003E8B18 File Offset: 0x003E6D18
		// (set) Token: 0x0600E05D RID: 57437 RVA: 0x003E8B20 File Offset: 0x003E6D20
		public int forever { get; set; }

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x0600E05E RID: 57438 RVA: 0x003E8B29 File Offset: 0x003E6D29
		// (set) Token: 0x0600E05F RID: 57439 RVA: 0x003E8B31 File Offset: 0x003E6D31
		public int id { get; set; }

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x0600E060 RID: 57440 RVA: 0x003E8B3A File Offset: 0x003E6D3A
		// (set) Token: 0x0600E061 RID: 57441 RVA: 0x003E8B42 File Offset: 0x003E6D42
		public int limit { get; set; }

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600E062 RID: 57442 RVA: 0x003E8B4B File Offset: 0x003E6D4B
		// (set) Token: 0x0600E063 RID: 57443 RVA: 0x003E8B53 File Offset: 0x003E6D53
		public int NewMsglogId { get; set; }

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x003E8B5C File Offset: 0x003E6D5C
		// (set) Token: 0x0600E065 RID: 57445 RVA: 0x003E8B64 File Offset: 0x003E6D64
		public int Price { get; set; }

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600E066 RID: 57446 RVA: 0x003E8B6D File Offset: 0x003E6D6D
		// (set) Token: 0x0600E067 RID: 57447 RVA: 0x003E8B75 File Offset: 0x003E6D75
		public int quantity { get; set; }

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600E068 RID: 57448 RVA: 0x003E8B7E File Offset: 0x003E6D7E
		// (set) Token: 0x0600E069 RID: 57449 RVA: 0x003E8B86 File Offset: 0x003E6D86
		public int shopType1 { get; set; }

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x003E8B8F File Offset: 0x003E6D8F
		// (set) Token: 0x0600E06B RID: 57451 RVA: 0x003E8B97 File Offset: 0x003E6D97
		public int shopType2 { get; set; }

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x0600E06C RID: 57452 RVA: 0x003E8BA0 File Offset: 0x003E6DA0
		// (set) Token: 0x0600E06D RID: 57453 RVA: 0x003E8BA8 File Offset: 0x003E6DA8
		public int userinfo { get; set; }

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x0600E06E RID: 57454 RVA: 0x003E8BB1 File Offset: 0x003E6DB1
		// (set) Token: 0x0600E06F RID: 57455 RVA: 0x003E8BB9 File Offset: 0x003E6DB9
		public int value { get; set; }

		// Token: 0x0600E070 RID: 57456 RVA: 0x003E8BC4 File Offset: 0x003E6DC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.forever = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.shopType1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.shopType2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
