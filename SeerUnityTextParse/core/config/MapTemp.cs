using System;

namespace core.config
{
	// Token: 0x02001D69 RID: 7529
	public class MapTemp : XlsConfigBase<MapTemp, IMapTempInfo>
	{
		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x003D6446 File Offset: 0x003D4646
		public override string fileName
		{
			get
			{
				return "map_temp";
			}
		}

		// Token: 0x0600DF13 RID: 57107 RVA: 0x003D6450 File Offset: 0x003D4650
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMapTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMapTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DF14 RID: 57108 RVA: 0x003D64A4 File Offset: 0x003D46A4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
