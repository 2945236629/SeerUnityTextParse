using System;

namespace core.config
{
	// Token: 0x02001DF3 RID: 7667
	public class IDangoInfo : IConfigItem
	{
		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600DFCA RID: 57290 RVA: 0x003E8074 File Offset: 0x003E6274
		// (set) Token: 0x0600DFCB RID: 57291 RVA: 0x003E807C File Offset: 0x003E627C
		public string describe { get; set; }

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x003E8085 File Offset: 0x003E6285
		// (set) Token: 0x0600DFCD RID: 57293 RVA: 0x003E808D File Offset: 0x003E628D
		public string gene { get; set; }

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600DFCE RID: 57294 RVA: 0x003E8096 File Offset: 0x003E6296
		// (set) Token: 0x0600DFCF RID: 57295 RVA: 0x003E809E File Offset: 0x003E629E
		public string name { get; set; }

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x003E80A7 File Offset: 0x003E62A7
		// (set) Token: 0x0600DFD1 RID: 57297 RVA: 0x003E80AF File Offset: 0x003E62AF
		public string skin { get; set; }

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600DFD2 RID: 57298 RVA: 0x003E80B8 File Offset: 0x003E62B8
		// (set) Token: 0x0600DFD3 RID: 57299 RVA: 0x003E80C0 File Offset: 0x003E62C0
		public int grade { get; set; }

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x003E80C9 File Offset: 0x003E62C9
		// (set) Token: 0x0600DFD5 RID: 57301 RVA: 0x003E80D1 File Offset: 0x003E62D1
		public int id { get; set; }

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x003E80DA File Offset: 0x003E62DA
		// (set) Token: 0x0600DFD7 RID: 57303 RVA: 0x003E80E2 File Offset: 0x003E62E2
		public int petID { get; set; }

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x003E80EB File Offset: 0x003E62EB
		// (set) Token: 0x0600DFD9 RID: 57305 RVA: 0x003E80F3 File Offset: 0x003E62F3
		public int value { get; set; }

		// Token: 0x0600DFDA RID: 57306 RVA: 0x003E80FC File Offset: 0x003E62FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gene = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.grade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
