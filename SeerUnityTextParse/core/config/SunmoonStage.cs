using System;

namespace core.config
{
	// Token: 0x02001E67 RID: 7783
	public class SunmoonStage : XlsConfigBase<SunmoonStage, ISunmoonStageInfo>
	{
		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x0600EA4E RID: 59982 RVA: 0x003E440D File Offset: 0x003E260D
		public override string fileName
		{
			get
			{
				return "sunmoon_stage";
			}
		}

		// Token: 0x0600EA4F RID: 59983 RVA: 0x003E4414 File Offset: 0x003E2614
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISunmoonStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISunmoonStageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA50 RID: 59984 RVA: 0x003E4468 File Offset: 0x003E2668
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
