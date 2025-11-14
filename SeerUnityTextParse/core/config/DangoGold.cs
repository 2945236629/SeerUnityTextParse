using System;

namespace core.config
{
	// Token: 0x02001DF8 RID: 7672
	public class DangoGold : XlsConfigBase<DangoGold, IDangoGoldInfo>
	{
		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600E006 RID: 57350 RVA: 0x003E84D4 File Offset: 0x003E66D4
		public override string fileName
		{
			get
			{
				return "dangoGold";
			}
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x003E84DC File Offset: 0x003E66DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoGoldInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoGoldInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x003E8530 File Offset: 0x003E6730
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
