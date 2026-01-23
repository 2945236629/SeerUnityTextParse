using System;

namespace core.config
{
	// Token: 0x02001DA8 RID: 7592
	public class ElfGachaReward : XlsConfigBase<ElfGachaReward, IElfGachaRewardInfo>
	{
		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x0600E063 RID: 57443 RVA: 0x003E6046 File Offset: 0x003E4246
		public override string fileName
		{
			get
			{
				return "elfGachaReward";
			}
		}

		// Token: 0x0600E064 RID: 57444 RVA: 0x003E6050 File Offset: 0x003E4250
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IElfGachaRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IElfGachaRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x003E60A4 File Offset: 0x003E42A4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
