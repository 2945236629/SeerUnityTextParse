using System;

namespace core.config
{
	// Token: 0x02001E4B RID: 7755
	public class Story1019 : XlsConfigBase<Story1019, IStory1019Info>
	{
		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600E8FE RID: 59646 RVA: 0x003E2B8D File Offset: 0x003E0D8D
		public override string fileName
		{
			get
			{
				return "story_1019";
			}
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x003E2B94 File Offset: 0x003E0D94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1019Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1019Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x003E2BE8 File Offset: 0x003E0DE8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
