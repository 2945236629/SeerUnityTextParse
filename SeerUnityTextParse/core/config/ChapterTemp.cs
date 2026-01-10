using System;

namespace core.config
{
	// Token: 0x02001CA3 RID: 7331
	public class ChapterTemp : XlsConfigBase<ChapterTemp, IChapterTempInfo>
	{
		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x003CC23A File Offset: 0x003CA43A
		public override string fileName
		{
			get
			{
				return "chapter_temp";
			}
		}

		// Token: 0x0600D6C1 RID: 54977 RVA: 0x003CC244 File Offset: 0x003CA444
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChapterTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChapterTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D6C2 RID: 54978 RVA: 0x003CC298 File Offset: 0x003CA498
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
