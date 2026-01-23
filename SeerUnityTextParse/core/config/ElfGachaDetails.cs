using System;

namespace core.config
{
	// Token: 0x02001DA6 RID: 7590
	public class ElfGachaDetails : XlsConfigBase<ElfGachaDetails, IElfGachaDetailsInfo>
	{
		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x0600E051 RID: 57425 RVA: 0x003E5EF7 File Offset: 0x003E40F7
		public override string fileName
		{
			get
			{
				return "elfGachaDetails";
			}
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x003E5F00 File Offset: 0x003E4100
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IElfGachaDetailsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IElfGachaDetailsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E053 RID: 57427 RVA: 0x003E5F54 File Offset: 0x003E4154
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
