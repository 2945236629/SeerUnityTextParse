using System;

namespace core.config
{
	// Token: 0x02001DF5 RID: 7669
	public class IDangoActionInfo : IConfigItem
	{
		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x003E8210 File Offset: 0x003E6410
		// (set) Token: 0x0600DFE1 RID: 57313 RVA: 0x003E8218 File Offset: 0x003E6418
		public string action { get; set; }

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x003E8221 File Offset: 0x003E6421
		// (set) Token: 0x0600DFE3 RID: 57315 RVA: 0x003E8229 File Offset: 0x003E6429
		public string describ { get; set; }

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x003E8232 File Offset: 0x003E6432
		// (set) Token: 0x0600DFE5 RID: 57317 RVA: 0x003E823A File Offset: 0x003E643A
		public string name { get; set; }

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600DFE6 RID: 57318 RVA: 0x003E8243 File Offset: 0x003E6443
		// (set) Token: 0x0600DFE7 RID: 57319 RVA: 0x003E824B File Offset: 0x003E644B
		public int[] dangoID { get; set; }

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600DFE8 RID: 57320 RVA: 0x003E8254 File Offset: 0x003E6454
		// (set) Token: 0x0600DFE9 RID: 57321 RVA: 0x003E825C File Offset: 0x003E645C
		public int actionTeam { get; set; }

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600DFEA RID: 57322 RVA: 0x003E8265 File Offset: 0x003E6465
		// (set) Token: 0x0600DFEB RID: 57323 RVA: 0x003E826D File Offset: 0x003E646D
		public int id { get; set; }

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x003E8276 File Offset: 0x003E6476
		// (set) Token: 0x0600DFED RID: 57325 RVA: 0x003E827E File Offset: 0x003E647E
		public int limitDango { get; set; }

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600DFEE RID: 57326 RVA: 0x003E8287 File Offset: 0x003E6487
		// (set) Token: 0x0600DFEF RID: 57327 RVA: 0x003E828F File Offset: 0x003E648F
		public int limitType { get; set; }

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600DFF0 RID: 57328 RVA: 0x003E8298 File Offset: 0x003E6498
		// (set) Token: 0x0600DFF1 RID: 57329 RVA: 0x003E82A0 File Offset: 0x003E64A0
		public int value { get; set; }

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x003E82AC File Offset: 0x003E64AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.action = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.actionTeam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.dangoID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.dangoID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.describ = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitDango = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
