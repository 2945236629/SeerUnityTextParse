using System;

namespace core.config
{
	// Token: 0x02001E4D RID: 7757
	public class Story1020 : XlsConfigBase<Story1020, IStory1020Info>
	{
		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x003E2D51 File Offset: 0x003E0F51
		public override string fileName
		{
			get
			{
				return "story_1020";
			}
		}

		// Token: 0x0600E917 RID: 59671 RVA: 0x003E2D58 File Offset: 0x003E0F58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1020Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1020Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x003E2DAC File Offset: 0x003E0FAC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
