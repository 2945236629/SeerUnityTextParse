using System;

namespace core.config
{
	// Token: 0x02001E94 RID: 7828
	public class OmniCoetusReward : XlsConfigBase<OmniCoetusReward, IOmniCoetusRewardInfo>
	{
		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x0600E646 RID: 58950 RVA: 0x003F0231 File Offset: 0x003EE431
		public override string fileName
		{
			get
			{
				return "omniCoetus_reward";
			}
		}

		// Token: 0x0600E647 RID: 58951 RVA: 0x003F0238 File Offset: 0x003EE438
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IOmniCoetusRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IOmniCoetusRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E648 RID: 58952 RVA: 0x003F028C File Offset: 0x003EE48C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
