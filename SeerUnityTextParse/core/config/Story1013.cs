using System;

namespace core.config
{
	// Token: 0x02001E47 RID: 7751
	public class Story1013 : XlsConfigBase<Story1013, IStory1013Info>
	{
		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600E8CE RID: 59598 RVA: 0x003E2805 File Offset: 0x003E0A05
		public override string fileName
		{
			get
			{
				return "story_1013";
			}
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x003E280C File Offset: 0x003E0A0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1013Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1013Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x003E2860 File Offset: 0x003E0A60
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
