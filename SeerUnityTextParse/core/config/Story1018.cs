using System;

namespace core.config
{
	// Token: 0x02001E49 RID: 7753
	public class Story1018 : XlsConfigBase<Story1018, IStory1018Info>
	{
		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600E8E6 RID: 59622 RVA: 0x003E29C9 File Offset: 0x003E0BC9
		public override string fileName
		{
			get
			{
				return "story_1018";
			}
		}

		// Token: 0x0600E8E7 RID: 59623 RVA: 0x003E29D0 File Offset: 0x003E0BD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1018Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1018Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x003E2A24 File Offset: 0x003E0C24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
