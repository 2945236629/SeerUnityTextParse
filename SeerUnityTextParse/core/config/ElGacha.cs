using System;

namespace core.config
{
	// Token: 0x02001DAC RID: 7596
	public class ElGacha : XlsConfigBase<ElGacha, IElGachaInfo>
	{
		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600E09B RID: 57499 RVA: 0x003E6422 File Offset: 0x003E4622
		public override string fileName
		{
			get
			{
				return "elGacha";
			}
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x003E642C File Offset: 0x003E462C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IElGachaInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IElGachaInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x003E6480 File Offset: 0x003E4680
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
