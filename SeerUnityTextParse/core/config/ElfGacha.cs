using System;

namespace core.config
{
	// Token: 0x02001DA4 RID: 7588
	public class ElfGacha : XlsConfigBase<ElfGacha, IElfGachaInfo>
	{
		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600E031 RID: 57393 RVA: 0x003E5CC9 File Offset: 0x003E3EC9
		public override string fileName
		{
			get
			{
				return "elfGacha";
			}
		}

		// Token: 0x0600E032 RID: 57394 RVA: 0x003E5CD0 File Offset: 0x003E3ED0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IElfGachaInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IElfGachaInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E033 RID: 57395 RVA: 0x003E5D24 File Offset: 0x003E3F24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
