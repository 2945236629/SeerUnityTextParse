using System;

namespace core.config
{
	// Token: 0x02001DF6 RID: 7670
	public class DangoGene : XlsConfigBase<DangoGene, IDangoGeneInfo>
	{
		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x0600DFF4 RID: 57332 RVA: 0x003E8376 File Offset: 0x003E6576
		public override string fileName
		{
			get
			{
				return "dangoGene";
			}
		}

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x003E8380 File Offset: 0x003E6580
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoGeneInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoGeneInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x003E83D4 File Offset: 0x003E65D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
