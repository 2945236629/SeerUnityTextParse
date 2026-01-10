using System;

namespace core.config
{
	// Token: 0x02001D34 RID: 7476
	public class IGoldeneggGameInfo : IConfigItem
	{
		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x0600DCFA RID: 56570 RVA: 0x003D3A54 File Offset: 0x003D1C54
		// (set) Token: 0x0600DCFB RID: 56571 RVA: 0x003D3A5C File Offset: 0x003D1C5C
		public int id { get; set; }

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x0600DCFC RID: 56572 RVA: 0x003D3A65 File Offset: 0x003D1C65
		// (set) Token: 0x0600DCFD RID: 56573 RVA: 0x003D3A6D File Offset: 0x003D1C6D
		public int monsterhp { get; set; }

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x003D3A76 File Offset: 0x003D1C76
		// (set) Token: 0x0600DCFF RID: 56575 RVA: 0x003D3A7E File Offset: 0x003D1C7E
		public int position { get; set; }

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x0600DD00 RID: 56576 RVA: 0x003D3A87 File Offset: 0x003D1C87
		// (set) Token: 0x0600DD01 RID: 56577 RVA: 0x003D3A8F File Offset: 0x003D1C8F
		public int round { get; set; }

		// Token: 0x0600DD02 RID: 56578 RVA: 0x003D3A98 File Offset: 0x003D1C98
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.position = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.round = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
