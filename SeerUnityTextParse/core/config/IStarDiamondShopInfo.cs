using System;

namespace core.config
{
	// Token: 0x02001F29 RID: 7977
	public class IStarDiamondShopInfo : IConfigItem
	{
		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x0600EC82 RID: 60546 RVA: 0x003F7F18 File Offset: 0x003F6118
		// (set) Token: 0x0600EC83 RID: 60547 RVA: 0x003F7F20 File Offset: 0x003F6120
		public string icon { get; set; }

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x0600EC84 RID: 60548 RVA: 0x003F7F29 File Offset: 0x003F6129
		// (set) Token: 0x0600EC85 RID: 60549 RVA: 0x003F7F31 File Offset: 0x003F6131
		public string name { get; set; }

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x0600EC86 RID: 60550 RVA: 0x003F7F3A File Offset: 0x003F613A
		// (set) Token: 0x0600EC87 RID: 60551 RVA: 0x003F7F42 File Offset: 0x003F6142
		public string reward { get; set; }

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600EC88 RID: 60552 RVA: 0x003F7F4B File Offset: 0x003F614B
		// (set) Token: 0x0600EC89 RID: 60553 RVA: 0x003F7F53 File Offset: 0x003F6153
		public int commodity { get; set; }

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x0600EC8A RID: 60554 RVA: 0x003F7F5C File Offset: 0x003F615C
		// (set) Token: 0x0600EC8B RID: 60555 RVA: 0x003F7F64 File Offset: 0x003F6164
		public int currency { get; set; }

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x0600EC8C RID: 60556 RVA: 0x003F7F6D File Offset: 0x003F616D
		// (set) Token: 0x0600EC8D RID: 60557 RVA: 0x003F7F75 File Offset: 0x003F6175
		public int grade { get; set; }

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600EC8E RID: 60558 RVA: 0x003F7F7E File Offset: 0x003F617E
		// (set) Token: 0x0600EC8F RID: 60559 RVA: 0x003F7F86 File Offset: 0x003F6186
		public int id { get; set; }

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600EC90 RID: 60560 RVA: 0x003F7F8F File Offset: 0x003F618F
		// (set) Token: 0x0600EC91 RID: 60561 RVA: 0x003F7F97 File Offset: 0x003F6197
		public int limit { get; set; }

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x0600EC92 RID: 60562 RVA: 0x003F7FA0 File Offset: 0x003F61A0
		// (set) Token: 0x0600EC93 RID: 60563 RVA: 0x003F7FA8 File Offset: 0x003F61A8
		public int MintmarkID { get; set; }

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600EC94 RID: 60564 RVA: 0x003F7FB1 File Offset: 0x003F61B1
		// (set) Token: 0x0600EC95 RID: 60565 RVA: 0x003F7FB9 File Offset: 0x003F61B9
		public int NewSeID { get; set; }

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x0600EC96 RID: 60566 RVA: 0x003F7FC2 File Offset: 0x003F61C2
		// (set) Token: 0x0600EC97 RID: 60567 RVA: 0x003F7FCA File Offset: 0x003F61CA
		public int price { get; set; }

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x0600EC98 RID: 60568 RVA: 0x003F7FD3 File Offset: 0x003F61D3
		// (set) Token: 0x0600EC99 RID: 60569 RVA: 0x003F7FDB File Offset: 0x003F61DB
		public int type { get; set; }

		// Token: 0x0600EC9A RID: 60570 RVA: 0x003F7FE4 File Offset: 0x003F61E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.commodity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.currency = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.grade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
