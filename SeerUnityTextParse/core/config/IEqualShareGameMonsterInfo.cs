using System;

namespace core.config
{
	// Token: 0x02001D0E RID: 7438
	public class IEqualShareGameMonsterInfo : IConfigItem
	{
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x0600DB72 RID: 56178 RVA: 0x003D1AF4 File Offset: 0x003CFCF4
		// (set) Token: 0x0600DB73 RID: 56179 RVA: 0x003D1AFC File Offset: 0x003CFCFC
		public int attack { get; set; }

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600DB74 RID: 56180 RVA: 0x003D1B05 File Offset: 0x003CFD05
		// (set) Token: 0x0600DB75 RID: 56181 RVA: 0x003D1B0D File Offset: 0x003CFD0D
		public int exp { get; set; }

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600DB76 RID: 56182 RVA: 0x003D1B16 File Offset: 0x003CFD16
		// (set) Token: 0x0600DB77 RID: 56183 RVA: 0x003D1B1E File Offset: 0x003CFD1E
		public int id { get; set; }

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x003D1B27 File Offset: 0x003CFD27
		// (set) Token: 0x0600DB79 RID: 56185 RVA: 0x003D1B2F File Offset: 0x003CFD2F
		public int recover { get; set; }

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600DB7A RID: 56186 RVA: 0x003D1B38 File Offset: 0x003CFD38
		// (set) Token: 0x0600DB7B RID: 56187 RVA: 0x003D1B40 File Offset: 0x003CFD40
		public int type { get; set; }

		// Token: 0x0600DB7C RID: 56188 RVA: 0x003D1B4C File Offset: 0x003CFD4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.attack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.recover = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
