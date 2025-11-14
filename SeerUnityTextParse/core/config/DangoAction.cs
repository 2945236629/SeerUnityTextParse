using System;

namespace core.config
{
	// Token: 0x02001DF4 RID: 7668
	public class DangoAction : XlsConfigBase<DangoAction, IDangoActionInfo>
	{
		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x003E8195 File Offset: 0x003E6395
		public override string fileName
		{
			get
			{
				return "dangoAction";
			}
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x003E819C File Offset: 0x003E639C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoActionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoActionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x003E81F0 File Offset: 0x003E63F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
