using System;

namespace core.config
{
	// Token: 0x02001DFE RID: 7678
	public class DangoLv : XlsConfigBase<DangoLv, IDangoLvInfo>
	{
		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x0600E034 RID: 57396 RVA: 0x003E883D File Offset: 0x003E6A3D
		public override string fileName
		{
			get
			{
				return "dangoLv";
			}
		}

		// Token: 0x0600E035 RID: 57397 RVA: 0x003E8844 File Offset: 0x003E6A44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoLvInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoLvInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E036 RID: 57398 RVA: 0x003E8898 File Offset: 0x003E6A98
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
