using System;

namespace core.config
{
	// Token: 0x02001EAA RID: 7850
	public class PetSkinRewardtype : XlsConfigBase<PetSkinRewardtype, IPetSkinRewardtypeInfo>
	{
		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x0600E730 RID: 59184 RVA: 0x003F132D File Offset: 0x003EF52D
		public override string fileName
		{
			get
			{
				return "pet_skin_rewardtype";
			}
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x003F1334 File Offset: 0x003EF534
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPetSkinRewardtypeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPetSkinRewardtypeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x003F1388 File Offset: 0x003EF588
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
