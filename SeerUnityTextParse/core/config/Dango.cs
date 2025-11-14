using System;

namespace core.config
{
	// Token: 0x02001DF2 RID: 7666
	public class Dango : XlsConfigBase<Dango, IDangoInfo>
	{
		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600DFC6 RID: 57286 RVA: 0x003E7FF7 File Offset: 0x003E61F7
		public override string fileName
		{
			get
			{
				return "dango";
			}
		}

		// Token: 0x0600DFC7 RID: 57287 RVA: 0x003E8000 File Offset: 0x003E6200
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFC8 RID: 57288 RVA: 0x003E8054 File Offset: 0x003E6254
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
