using System;

namespace core.config
{
	// Token: 0x02001D50 RID: 7504
	public class ILightBookTempInfo : IConfigItem
	{
		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600DDFA RID: 56826 RVA: 0x003D4EA4 File Offset: 0x003D30A4
		// (set) Token: 0x0600DDFB RID: 56827 RVA: 0x003D4EAC File Offset: 0x003D30AC
		public string coinid { get; set; }

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600DDFC RID: 56828 RVA: 0x003D4EB5 File Offset: 0x003D30B5
		// (set) Token: 0x0600DDFD RID: 56829 RVA: 0x003D4EBD File Offset: 0x003D30BD
		public string monsterID { get; set; }

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600DDFE RID: 56830 RVA: 0x003D4EC6 File Offset: 0x003D30C6
		// (set) Token: 0x0600DDFF RID: 56831 RVA: 0x003D4ECE File Offset: 0x003D30CE
		public string needmonID { get; set; }

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600DE00 RID: 56832 RVA: 0x003D4ED7 File Offset: 0x003D30D7
		// (set) Token: 0x0600DE01 RID: 56833 RVA: 0x003D4EDF File Offset: 0x003D30DF
		public string price { get; set; }

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x0600DE02 RID: 56834 RVA: 0x003D4EE8 File Offset: 0x003D30E8
		// (set) Token: 0x0600DE03 RID: 56835 RVA: 0x003D4EF0 File Offset: 0x003D30F0
		public int id { get; set; }

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x0600DE04 RID: 56836 RVA: 0x003D4EF9 File Offset: 0x003D30F9
		// (set) Token: 0x0600DE05 RID: 56837 RVA: 0x003D4F01 File Offset: 0x003D3101
		public int newest { get; set; }

		// Token: 0x0600DE06 RID: 56838 RVA: 0x003D4F0C File Offset: 0x003D310C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coinid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.needmonID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.newest = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
