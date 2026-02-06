using System;

namespace core.config
{
	// Token: 0x02001F91 RID: 8081
	public class Story1021 : XlsConfigBase<Story1021, IStory1021Info>
	{
		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x0600F3A4 RID: 62372 RVA: 0x0040FD61 File Offset: 0x0040DF61
		public override string fileName
		{
			get
			{
				return "story_1021";
			}
		}

		// Token: 0x0600F3A5 RID: 62373 RVA: 0x0040FD68 File Offset: 0x0040DF68
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1021Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1021Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F3A6 RID: 62374 RVA: 0x0040FDBC File Offset: 0x0040DFBC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
