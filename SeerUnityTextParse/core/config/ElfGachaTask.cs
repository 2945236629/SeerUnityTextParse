using System;

namespace core.config
{
	// Token: 0x02001DAA RID: 7594
	public class ElfGachaTask : XlsConfigBase<ElfGachaTask, IElfGachaTaskInfo>
	{
		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600E085 RID: 57477 RVA: 0x003E628D File Offset: 0x003E448D
		public override string fileName
		{
			get
			{
				return "elfGachaTask";
			}
		}

		// Token: 0x0600E086 RID: 57478 RVA: 0x003E6294 File Offset: 0x003E4494
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IElfGachaTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IElfGachaTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E087 RID: 57479 RVA: 0x003E62E8 File Offset: 0x003E44E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
