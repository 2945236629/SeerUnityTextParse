using System;

namespace core.config
{
	// Token: 0x02001E63 RID: 7779
	public class SunmoonCareer : XlsConfigBase<SunmoonCareer, ISunmoonCareerInfo>
	{
		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600EA16 RID: 59926 RVA: 0x003E4022 File Offset: 0x003E2222
		public override string fileName
		{
			get
			{
				return "sunmoon_career";
			}
		}

		// Token: 0x0600EA17 RID: 59927 RVA: 0x003E402C File Offset: 0x003E222C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISunmoonCareerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISunmoonCareerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA18 RID: 59928 RVA: 0x003E4080 File Offset: 0x003E2280
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
