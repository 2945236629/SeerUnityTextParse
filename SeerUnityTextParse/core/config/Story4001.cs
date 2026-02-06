using System;

namespace core.config
{
	// Token: 0x02001FA5 RID: 8101
	public class Story4001 : XlsConfigBase<Story4001, IStory4001Info>
	{
		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x0600F494 RID: 62612 RVA: 0x00410F09 File Offset: 0x0040F109
		public override string fileName
		{
			get
			{
				return "story_4001";
			}
		}

		// Token: 0x0600F495 RID: 62613 RVA: 0x00410F10 File Offset: 0x0040F110
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory4001Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory4001Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F496 RID: 62614 RVA: 0x00410F64 File Offset: 0x0040F164
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
