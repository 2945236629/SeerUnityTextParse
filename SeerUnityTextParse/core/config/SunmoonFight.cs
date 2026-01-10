using System;

namespace core.config
{
	// Token: 0x02001E65 RID: 7781
	public class SunmoonFight : XlsConfigBase<SunmoonFight, ISunmoonFightInfo>
	{
		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600EA3C RID: 59964 RVA: 0x003E42B8 File Offset: 0x003E24B8
		public override string fileName
		{
			get
			{
				return "sunmoon_fight";
			}
		}

		// Token: 0x0600EA3D RID: 59965 RVA: 0x003E42C0 File Offset: 0x003E24C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISunmoonFightInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISunmoonFightInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA3E RID: 59966 RVA: 0x003E4314 File Offset: 0x003E2514
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
