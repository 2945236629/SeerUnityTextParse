using System;

namespace core.config
{
	// Token: 0x02001E69 RID: 7785
	public class SunmoonStagewave : XlsConfigBase<SunmoonStagewave, ISunmoonStagewaveInfo>
	{
		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600EA62 RID: 60002 RVA: 0x003E457E File Offset: 0x003E277E
		public override string fileName
		{
			get
			{
				return "sunmoon_stagewave";
			}
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x003E4588 File Offset: 0x003E2788
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISunmoonStagewaveInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISunmoonStagewaveInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x003E45DC File Offset: 0x003E27DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
