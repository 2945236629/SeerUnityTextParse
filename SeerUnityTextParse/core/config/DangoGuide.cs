using System;

namespace core.config
{
	// Token: 0x02001DFA RID: 7674
	public class DangoGuide : XlsConfigBase<DangoGuide, IDangoGuideInfo>
	{
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x003E85D2 File Offset: 0x003E67D2
		public override string fileName
		{
			get
			{
				return "dangoGuide";
			}
		}

		// Token: 0x0600E015 RID: 57365 RVA: 0x003E85DC File Offset: 0x003E67DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoGuideInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoGuideInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x003E8630 File Offset: 0x003E6830
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
