using System;

namespace core.config
{
	// Token: 0x02001D6A RID: 7530
	public class IMapTempInfo : IConfigItem
	{
		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x003D64C4 File Offset: 0x003D46C4
		// (set) Token: 0x0600DF17 RID: 57111 RVA: 0x003D64CC File Offset: 0x003D46CC
		public string DeviceID { get; set; }

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600DF18 RID: 57112 RVA: 0x003D64D5 File Offset: 0x003D46D5
		// (set) Token: 0x0600DF19 RID: 57113 RVA: 0x003D64DD File Offset: 0x003D46DD
		public string Ename { get; set; }

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600DF1A RID: 57114 RVA: 0x003D64E6 File Offset: 0x003D46E6
		// (set) Token: 0x0600DF1B RID: 57115 RVA: 0x003D64EE File Offset: 0x003D46EE
		public string name { get; set; }

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600DF1C RID: 57116 RVA: 0x003D64F7 File Offset: 0x003D46F7
		// (set) Token: 0x0600DF1D RID: 57117 RVA: 0x003D64FF File Offset: 0x003D46FF
		public string notes { get; set; }

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x003D6508 File Offset: 0x003D4708
		// (set) Token: 0x0600DF1F RID: 57119 RVA: 0x003D6510 File Offset: 0x003D4710
		public string sound { get; set; }

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x0600DF20 RID: 57120 RVA: 0x003D6519 File Offset: 0x003D4719
		// (set) Token: 0x0600DF21 RID: 57121 RVA: 0x003D6521 File Offset: 0x003D4721
		public int[] NPCID { get; set; }

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x0600DF22 RID: 57122 RVA: 0x003D652A File Offset: 0x003D472A
		// (set) Token: 0x0600DF23 RID: 57123 RVA: 0x003D6532 File Offset: 0x003D4732
		public int[] NPCXYZ { get; set; }

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x003D653B File Offset: 0x003D473B
		// (set) Token: 0x0600DF25 RID: 57125 RVA: 0x003D6543 File Offset: 0x003D4743
		public int[] PlayerXYZ { get; set; }

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0600DF26 RID: 57126 RVA: 0x003D654C File Offset: 0x003D474C
		// (set) Token: 0x0600DF27 RID: 57127 RVA: 0x003D6554 File Offset: 0x003D4754
		public int[] WildBossID { get; set; }

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x003D655D File Offset: 0x003D475D
		// (set) Token: 0x0600DF29 RID: 57129 RVA: 0x003D6565 File Offset: 0x003D4765
		public int[] WildBossPoint { get; set; }

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600DF2A RID: 57130 RVA: 0x003D656E File Offset: 0x003D476E
		// (set) Token: 0x0600DF2B RID: 57131 RVA: 0x003D6576 File Offset: 0x003D4776
		public int[] WildBossWeight { get; set; }

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x0600DF2C RID: 57132 RVA: 0x003D657F File Offset: 0x003D477F
		// (set) Token: 0x0600DF2D RID: 57133 RVA: 0x003D6587 File Offset: 0x003D4787
		public int enterMap { get; set; }

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x0600DF2E RID: 57134 RVA: 0x003D6590 File Offset: 0x003D4790
		// (set) Token: 0x0600DF2F RID: 57135 RVA: 0x003D6598 File Offset: 0x003D4798
		public int GroupID { get; set; }

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x0600DF30 RID: 57136 RVA: 0x003D65A1 File Offset: 0x003D47A1
		// (set) Token: 0x0600DF31 RID: 57137 RVA: 0x003D65A9 File Offset: 0x003D47A9
		public int id { get; set; }

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x0600DF32 RID: 57138 RVA: 0x003D65B2 File Offset: 0x003D47B2
		// (set) Token: 0x0600DF33 RID: 57139 RVA: 0x003D65BA File Offset: 0x003D47BA
		public int MapRatio { get; set; }

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0600DF34 RID: 57140 RVA: 0x003D65C3 File Offset: 0x003D47C3
		// (set) Token: 0x0600DF35 RID: 57141 RVA: 0x003D65CB File Offset: 0x003D47CB
		public int pic { get; set; }

		// Token: 0x0600DF36 RID: 57142 RVA: 0x003D65D4 File Offset: 0x003D47D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DeviceID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Ename = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GroupID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MapRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NPCID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.NPCID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NPCXYZ = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.NPCXYZ[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.PlayerXYZ = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.PlayerXYZ[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WildBossID = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.WildBossID[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WildBossPoint = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.WildBossPoint[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WildBossWeight = new int[num6];
				for (int n = 0; n < num6; n++)
				{
					this.WildBossWeight[n] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.enterMap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.notes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sound = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
