using System;

namespace core.config
{
	// Token: 0x02001DFC RID: 7676
	public class DangoHouse : XlsConfigBase<DangoHouse, IDangoHouseInfo>
	{
		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600E026 RID: 57382 RVA: 0x003E8737 File Offset: 0x003E6937
		public override string fileName
		{
			get
			{
				return "dangoHouse";
			}
		}

		// Token: 0x0600E027 RID: 57383 RVA: 0x003E8740 File Offset: 0x003E6940
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoHouseInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoHouseInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E028 RID: 57384 RVA: 0x003E8794 File Offset: 0x003E6994
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
