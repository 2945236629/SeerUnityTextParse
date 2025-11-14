using System;

namespace core.config
{
	// Token: 0x02001E04 RID: 7684
	public class DangoStory : XlsConfigBase<DangoStory, IDangoStoryInfo>
	{
		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600E080 RID: 57472 RVA: 0x003E8DB1 File Offset: 0x003E6FB1
		public override string fileName
		{
			get
			{
				return "dangoStory";
			}
		}

		// Token: 0x0600E081 RID: 57473 RVA: 0x003E8DB8 File Offset: 0x003E6FB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoStoryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoStoryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E082 RID: 57474 RVA: 0x003E8E0C File Offset: 0x003E700C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
