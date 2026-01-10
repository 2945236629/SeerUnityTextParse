using System;

namespace core.config
{
	// Token: 0x02001C53 RID: 7251
	public class ArchivesStoryTemp : XlsConfigBase<ArchivesStoryTemp, IArchivesStoryTempInfo>
	{
		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600D37E RID: 54142 RVA: 0x003C831E File Offset: 0x003C651E
		public override string fileName
		{
			get
			{
				return "archivesStory_temp";
			}
		}

		// Token: 0x0600D37F RID: 54143 RVA: 0x003C8328 File Offset: 0x003C6528
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IArchivesStoryTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IArchivesStoryTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D380 RID: 54144 RVA: 0x003C837C File Offset: 0x003C657C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
